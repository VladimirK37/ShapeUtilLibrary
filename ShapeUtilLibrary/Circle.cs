namespace ShapeUtilLibrary
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Радиус
        /// </summary>
        private double Radius { get; }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        ///  Получение площади круга
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public override double GetArea()
        {
            if (!IsValid())
                throw new ArgumentException("The circle does not exist");

            return Math.PI * Math.Pow(Radius, 2);
        }

        /// <summary>
        /// Проверка существования радиуса круга
        /// </summary>
        public override bool IsValid()
        {
            return Radius > 0;
        }
    }
}
