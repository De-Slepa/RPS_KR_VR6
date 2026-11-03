using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ectrusion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            var m = Db.GetMaterials()[0];
            var r = Db.GetRange(m.Id);
            double eta = ViscosityModel.Calculate(m, 180, 30);
            MessageBox.Show(m.Name + ": T " + r.TMin + ".." + r.TMax +
                            ", eta(180; 30) = " + eta.ToString("F4"));
        }
    }
}
