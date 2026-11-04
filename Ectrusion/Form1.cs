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
using System.Windows.Forms.DataVisualization.Charting;

namespace Ectrusion
{
    public partial class Form1 : Form
    {
        private double[] _tValues;
        private double[] _gValues;
        private double[,] _eta;
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

            cmbAxis.Items.Add("От температуры T (γ = const)");
            cmbAxis.Items.Add("От скорости сдвига γ (T = const)");
            cmbAxis.SelectedIndex = 0;

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

        private void cmbAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawChart();
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

            int countT = (int)Math.Floor((tMax - tMin) / tStep + 1e-9) + 1;
            int countG = (int)Math.Floor((gMax - gMin) / gStep + 1e-9) + 1;
            if (countT > 1000 || countG > 1000)
            {
                MessageBox.Show("Слишком много точек. Увеличьте шаг.");
                return;
            }

            var m = new Material { Mu0 = mu0, B = b, T0 = t0, N = n };

            _tValues = new double[countT];
            _gValues = new double[countG];
            _eta = new double[countT, countG];
            for (int i = 0; i < countT; i++) _tValues[i] = tMin + i * tStep;
            for (int j = 0; j < countG; j++) _gValues[j] = gMin + j * gStep;
            for (int i = 0; i < countT; i++)
                for (int j = 0; j < countG; j++)
                    _eta[i, j] = ViscosityModel.Calculate(m, _tValues[i], _gValues[j]);

            FillTable();
            DrawChart();
        }
        private void FillTable()
        {
            dgvResult.Columns.Clear();
            dgvResult.Columns.Add("colT", "T, °C  \\  γ, 1/с");
            for (int j = 0; j < _gValues.Length; j++)
                dgvResult.Columns.Add("colG" + j, _gValues[j].ToString("0.##"));

            for (int i = 0; i < _tValues.Length; i++)
            {
                var row = new List<object> { _tValues[i].ToString("0.##") };
                for (int j = 0; j < _gValues.Length; j++)
                    row.Add(_eta[i, j].ToString("F2"));
                dgvResult.Rows.Add(row.ToArray());
            }
        }
        private void DrawChart()
        {
            chartResult.Series.Clear();
            chartResult.Titles.Clear();
            if (_eta == null) return;

            bool byT = cmbAxis.SelectedIndex == 0;   // по оси X температура?
            var area = chartResult.ChartAreas[0];
            area.AxisX.Minimum = double.NaN;
            area.AxisX.Maximum = double.NaN;
            area.AxisY.Minimum = double.NaN;
            area.AxisY.Maximum = double.NaN;
            area.AxisX.Title = byT ? "Температура T, °C" : "Скорость деформации сдвига γ, 1/с";
            area.AxisY.Title = "Вязкость η, Па·с";
            area.AxisX.IsStartedFromZero = false;
            area.AxisY.IsStartedFromZero = false;
            area.AxisX.MajorGrid.LineColor = Color.LightGray;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            chartResult.Titles.Add("Вязкость экструдата: " + cmbMaterial.Text);

            int fixedCount = byT ? _gValues.Length : _tValues.Length;
            int pointCount = byT ? _tValues.Length : _gValues.Length;

            foreach (int k in Pick3(fixedCount))
            {
                string name = byT
                    ? "γ = " + _gValues[k].ToString("0.##") + " 1/с"
                    : "T = " + _tValues[k].ToString("0.##") + " °C";

                var s = new Series(name)
                {
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 2,
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 5
                };

                for (int i = 0; i < pointCount; i++)
                {
                    if (byT) s.Points.AddXY(_tValues[i], _eta[i, k]);
                    else s.Points.AddXY(_gValues[i], _eta[k, i]);
                }
                chartResult.Series.Add(s);
            }
            area.RecalculateAxesScale();
        }

        private static int[] Pick3(int count)
        {
            if (count <= 1) return new[] { 0 };
            if (count == 2) return new[] { 0, 1 };
            return new[] { 0, count / 2, count - 1 };
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
