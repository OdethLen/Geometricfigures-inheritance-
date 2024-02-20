using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricfigures
{
    internal class Geometricfigure
    {


        //Properties
        protected int numsides;

        public int Numsides
        {
            get { return numsides; }
            set { numsides = value; }
        }

        protected string polygon;

        public string Polygon
        {
            get { return polygon; }
            set { polygon = value; }
        }


        protected int side_length;

        public int Side_length
        {
            get { return side_length; }
            set { side_length = value; }
        }


        //Constructor
        public Geometricfigure()
        {
            numsides = 0;
            polygon = "";
        }

        //Method 

        public int Getperimeter()
        {
            return numsides * side_length;
        }

    }
}
