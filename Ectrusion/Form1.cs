using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Ectrusion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvResult.ReadOnly = true;
            dgvResult.AllowUserToAddRows = false;
            dgvResult.RowHeadersVisible = false;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                cmbMaterial.DataSource = Db.GetMaterials();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось получить данные из БД: " + ex.Message);
            }
        }

        // При выборе материала берем из БД его коэффициенты и диапазоны
        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            var m = cmbMaterial.SelectedItem as Material;
            if (m == null) return;

            txtMu0.Text = Fmt(m.Mu0);
            txtB.Text = Fmt(m.B);
            txtT0.Text = Fmt(m.T0);
            txtN.Text = Fmt(m.N);

            var r = Db.GetRange(m.Id);
            if (r == null) return;
            txtTMin.Text = Fmt(r.TMin);
            txtTMax.Text = Fmt(r.TMax);
            txtTStep.Text = Fmt(r.TStep);
            txtGMin.Text = Fmt(r.GammaMin);
            txtGMax.Text = Fmt(r.GammaMax);
            txtGStep.Text = Fmt(r.GammaStep);
        }

        // строим таблицу
        private void button1_Click(object sender, EventArgs e)
        {
            double mu0, b, t0, n, tMin, tMax, tStep, gMin, gMax, gStep;
            if (!TryRead(txtMu0, "μ₀", out mu0)) return;
            if (!TryRead(txtB, "b", out b)) return;
            if (!TryRead(txtT0, "T₀", out t0)) return;
            if (!TryRead(txtN, "n", out n)) return;
            if (!TryRead(txtTMin, "T min", out tMin)) return;
            if (!TryRead(txtTMax, "T max", out tMax)) return;
            if (!TryRead(txtTStep, "Шаг T", out tStep)) return;
            if (!TryRead(txtGMin, "γ min", out gMin)) return;
            if (!TryRead(txtGMax, "γ max", out gMax)) return;
            if (!TryRead(txtGStep, "Шаг γ", out gStep)) return;

            if (tStep <= 0 || gStep <= 0 || tMin > tMax || gMin > gMax || gMin <= 0)
            {
                MessageBox.Show("Проверьте диапазоны: шаги должны быть больше 0, " +
                                "минимум не больше максимума, γ min больше 0.");
                return;
            }

            var m = new Material { Mu0 = mu0, B = b, T0 = t0, N = n };

            int countT = (int)Math.Floor((tMax - tMin) / tStep + 1e-9) + 1;
            int countG = (int)Math.Floor((gMax - gMin) / gStep + 1e-9) + 1;

            dgvResult.Columns.Clear();
            dgvResult.Columns.Add("colT", "T, °C  \\  γ, 1/с");
            for (int j = 0; j < countG; j++)
            {
                double g = gMin + j * gStep;
                dgvResult.Columns.Add("colG" + j, g.ToString("0.##"));
            }

            for (int i = 0; i < countT; i++)
            {
                double t = tMin + i * tStep;
                var row = new List<object> { t.ToString("0.##") };
                for (int j = 0; j < countG; j++)
                {
                    double g = gMin + j * gStep;
                    row.Add(ViscosityModel.Calculate(m, t, g).ToString("F2"));
                }
                dgvResult.Rows.Add(row.ToArray());
            }
        }

        private static string Fmt(double x)
        {
            return x.ToString(CultureInfo.InvariantCulture);
        }

        // Читает число из поля
        private bool TryRead(TextBox box, string name, out double value)
        {
            string s = box.Text.Trim().Replace(',', '.');
            if (!double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out value))
            {
                MessageBox.Show("Введите число в поле «" + name + "».");
                box.Focus();
                return false;
            }
            return true;
        }
    }
}
