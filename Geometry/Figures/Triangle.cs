using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Figures
{
    public class Triangle : Figure
    {
        /// <summary>
        /// Проверяет является ли треугольник прямоугольным
        /// </summary>
        public bool IsRight
        {
            get
            {
                int maxVal = Sides.Max();
                int[] arrWithoutMax = CreateArrWithoutVal(Sides, maxVal);
                return Math.Pow(maxVal, 2) == arrWithoutMax.Select(x => x * x).Sum();
            }
        }

        public Triangle(params int[] sides)
        {
            int maxVal = sides.Max();
            int[] arrWithoutMax = CreateArrWithoutVal(sides, maxVal);

            if (maxVal >= arrWithoutMax.Sum())
                throw new ArgumentException("Сумма длин двух сторон должна быть больше длины третьей");

            Sides = sides;
        }

        public override double GetShapeArea()
        {
            double semiPerimeter = (double)Sides.Sum() / 2;
            double res = semiPerimeter;

            for (uint i = 0; i < Sides.Length; i++)
                res *= semiPerimeter - Sides[i];

            return Math.Sqrt(res);
        }

        /// <summary>
        /// Удаляет первое вхождение указанного числа
        /// </summary>
        /// <param name="sides">Массив, в котором удаляется указанное число</param>
        /// <param name="val">Удаляемое число</param>
        /// <returns>Массив той же длины без этого числа</returns>
        private static int[] CreateArrWithoutVal(int[] sides, int val)
        {
            var sidesCopy = new int[sides.Length];
            Array.Copy(sides, sidesCopy, sides.Length);
            
            for (int i = 0; i < sidesCopy.Length; i++)
            {
                if (sidesCopy[i] == val)
                {
                    sidesCopy[i] = 0;
                    break;
                }
            }
            return sidesCopy;
        }
    }
}
