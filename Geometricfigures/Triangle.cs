using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricfigures
{
    internal class Triangle: Geometricfigure
    {
        private int basetri;

        public int Basetri
        {
            get { return basetri; }
            set { basetri = value; }
        }

        private int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        //Constructor 
        public Triangle()
        {
            height = 0;
            basetri = 0;
        }

        //Method 

        public int Triangle_area()
        {
            return (basetri * height) / 2;
        }

    }
}
