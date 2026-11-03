using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ectrusion
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Mu0 { get; set; }
        public double B { get; set; }
        public double T0 { get; set; }
        public double N { get; set; }

        public override string ToString() => Name;
    }
}
