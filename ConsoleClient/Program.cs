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


        static void Main()
        {

            // Использование существующих фигур
            var triangle = new Triangle(8, 7, 7);
            Console.WriteLine(triangle.GetShapeArea());

            var triangle2 = new Triangle(3, 4, 6);
            Console.WriteLine(triangle2.GetShapeArea());
            Console.WriteLine(triangle2.IsRight);

            var circle = new Circle(3);
            Console.WriteLine(circle.GetShapeArea());
        }
    }
}
