using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ectrusion
{
    public static class ViscosityModel
    {
        public static double Calculate(Material m, double t, double gamma)
        {
            return m.Mu0 * Math.Exp(m.B * (t - m.T0)) * Math.Pow(gamma, m.N - 1);
        }
    }
}
