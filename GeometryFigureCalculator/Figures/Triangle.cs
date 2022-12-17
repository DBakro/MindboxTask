namespace GeometryFigureCalculator.Figures
{
    public class Triangle : IGeometryFigure
    {
        #region Properties

        /// <summary>
        /// Первая сторона треугольника
        /// </summary>
        private double FirstSide { get; }

        /// <summary>
        /// Вторая сторона треугольника
        /// </summary>
        private double SecondSide { get; }

        /// <summary>
        /// Третья сторона треугольника
        /// </summary>
        private double ThirdSide { get; }

        #endregion

        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="firstSide">Первая сторона</param>
        /// <param name="secondSide">Вторая сторона</param>
        /// <param name="thirdSide">Третья сторона</param>
        /// <exception cref="ArgumentOutOfRangeException">Если одна из сторон треугольника имеет отрицательное значение</exception>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицательным значением");

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        #region Methods

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns>Возвращает площаль треугольника</returns>
        public double CalculateSquare()
        {
            double[] sides = new [] { FirstSide, SecondSide, ThirdSide };
            double p = sides.Sum() / 2;
            double agr = sides.Aggregate(1.0, (total, next) => (p - next) * total);

            return Math.Sqrt(p * agr);
        }

        /// <summary>
        /// Проверка является ли треугольник прямоугольным
        /// </summary>
        /// <returns>Возвращает true, если треугольник прямоугольный. Иначе false.</returns>

        public bool IsRightTringle()
        {
            double[] sides = new [] { FirstSide, SecondSide, ThirdSide };
            double maxSide = sides.Max();
            return Math.Pow(maxSide, 2) == sides.Where(s => s != maxSide).Sum(s => Math.Pow(s, 2));
        }

        #endregion
    }
}