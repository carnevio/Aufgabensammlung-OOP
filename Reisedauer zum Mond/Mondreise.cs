using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reisedauer_zum_Mond
{
    internal class Mondreise
    {
        double speedKmh;
        
        public double SpeedKmh
        {
            get { return speedKmh; }
            set { speedKmh = value; }
        }

        public Mondreise(double speedKmh)
        {
            this.speedKmh = speedKmh;
        }

        public double ReisedauerInTagen()
        {
            return 384400 / speedKmh / 24;
        }

        public double ReisedauerInStunden()
        {
            return 384400 / speedKmh;
        }
    }
}
