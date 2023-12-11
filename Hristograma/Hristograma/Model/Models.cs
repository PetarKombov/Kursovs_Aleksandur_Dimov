using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hristograma.Module
{
    public class Models
    {
        public int Broi { get;  set; }
        public List<int> Chisla { get; private set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double P3 { get; set; }
        public double P4 { get; set; }
        public double P5 { get; set; }
        public Models(int broi, List<int> chisla)
        {
            Broi = broi;
            Chisla = chisla;
        }
    }
}
