
using Geometricfigures;
using System;

namespace A_person
{
    class Program
    {
        static void Main(string[] args)
        {


            Triangle triangle_one = new Triangle();
            triangle_one.Numsides = 3;
            triangle_one.Polygon = "Triangle";
            triangle_one.Side_length = 10;
            triangle_one.Basetri = 15;
            triangle_one.Height = 2;
            triangle_one.Triangle_area();
            Console.WriteLine("\nNumber of sides: " + triangle_one.Numsides + "\nPolygon: " + triangle_one.Polygon + "\nPerimeter: " + triangle_one.Getperimeter() + "\nArea: " + triangle_one.Triangle_area());

            //Geometricfigures Figure = new Geometricfigures();
            //Figure.Numsides = 10;
            //Figure.Polygon = "Decagon";
            //Figure.Side_length = 5;
            //Figure.Getperimeter();
            //Console.WriteLine("\nNum of sides:" + Figure.Numsides + "\nPolygon:" + Figure.Polygon + "\nPerimeter:" +Figure.Getperimeter ());
        }
    }
}
