using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Geometry;
using Geometry.Figures;

namespace Client
{
    internal class Client
    {
        // Пользователь имеет возможность добавления своей фигуры
        public class Rectangle : Figure
        {
            public Rectangle(params int[] sides) { Sides = sides; }//: base (sides){ }

            public override double GetShapeArea() =>
                Sides[0] * Sides[1];
        }

        static void Main()
        {
            //Figure client = new Rectangle(5, 7, 5, 7);
            //Console.WriteLine(client.GetShapeArea());

            //// Использование существующих фигур
            //var triangle = new Triangle(8, 7, 7);
            //Console.WriteLine(triangle.GetShapeArea());

            //var triangle2 = new Triangle(3, 4, 6);
            //Console.WriteLine(triangle2.GetShapeArea());
            //Console.WriteLine(triangle2.IsRight);

            // Использование существующих фигур
            //var triangle3 = new Triangle(8, 1, 2);

            //var circle = new Circle(3);
            //Console.WriteLine(circle.GetShapeArea());

            var ekz = new Rectangle(0, 4);
        }
    }
}
