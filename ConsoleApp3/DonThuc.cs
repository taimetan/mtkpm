    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class DonThuc
    {
        public double HeSo { get; set; }
        public int Bac { get; set; }

        public DonThuc(double heSo, int bac)
        {
            HeSo = heSo;
            Bac = bac;
        }

        public double TinhGiaTri(double x)
        {
            return HeSo * Math.Pow(x, Bac);
        }

        public override string ToString()
        {
            return $"{HeSo}x^{Bac}";
        }
    }
}
