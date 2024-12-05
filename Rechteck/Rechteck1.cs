using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck
{
    internal class Rechteck1
    {
        public double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double width;

        public double Width
        { 
            get { return width; } 
            set { width = value; } 
        }

        public double GetArea(double height, double width)
        {
            return height * width;
        }
    }
}
