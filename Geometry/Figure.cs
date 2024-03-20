namespace Geometry
{
    /// <summary>
    /// Конвейер фигур
    /// </summary>
    public abstract class Figure
    {

        private int[] _sides;
        /// <summary>
        /// Хранит длины сторон фигуры
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Возникает если количество сторон фигуры < 3 или длина одной из сторон < 1
        /// </exception>
        protected int[] Sides { get => _sides; init
            {
                if (value.Length < 3) throw new ArgumentException("Количество сторон фигуры как минимум 3");

                for (int i = 0; i < value.Length; i++)
                    if (value[i] < 1) throw new ArgumentException("Длины сторон не могут быть отрицательными или нулевыми");

                _sides = value;
            }
        }

        /// <summary>
        /// Радиус фигуры
        /// </summary>
        protected uint _radius { get; init; }

        /// <summary>
        /// Возвращает площадь фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double GetShapeArea();
    }
}
