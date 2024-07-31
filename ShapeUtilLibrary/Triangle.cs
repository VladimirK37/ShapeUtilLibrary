namespace ShapeUtilLibrary
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Маленькая сторона
        /// </summary>
        public double Side1 { get; }

        /// <summary>
        /// Сторона треугольника
        /// </summary>
        public double Side2 { get; }

        /// <summary>
        /// Большая сторона 
        /// </summary>
        public double Side3 { get; }

        /// <summary>
        /// Сортировка переменных, хранящие стороны треугольника, в порядке возрастания.
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 > side2)
                HelpUtil.SwapVariables(ref side1, ref side2);

            if (side1 > side3)
                HelpUtil.SwapVariables(ref side1, ref side3);

            if (side2 > side3)
                HelpUtil.SwapVariables(ref side2, ref side3);

            // Сохраните значение так, чтобы сторона 1 хранила минимальное значение, а сторона 3 - максимальное.
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        /// <summary>
        /// Получение площади
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public override double GetArea()
        {
            if (!IsValid())
                throw new ArgumentException("The triangle does not exist.");

            double halfPerimeter = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - Side1) * (halfPerimeter - Side2) * (halfPerimeter - Side3));
        }

        /// <summary>
        /// Проверяет валидности сторон
        /// </summary>
        public override bool IsValid()
        {
            return Side1 > 0 && Side2 > 0 && Side3 > 0 && Side1 + Side2 > Side3;
        }

        /// <summary>
        /// Проверяет правильность треугольника.
        /// </summary>
        public bool IsRightTriangle()
        {
            if (IsValid())
            {
                return Math.Pow(Side3, 2) == Math.Pow(Side2, 2) + Math.Pow(Side1, 2);
            }

            return false;
        }
    }
}