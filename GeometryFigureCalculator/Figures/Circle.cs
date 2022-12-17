namespace GeometryFigureCalculator.Figures
{
    public class Circle : IGeometryFigure
    {
        #region Properties

        /// <summary>
        /// Радиус окружности
        /// </summary>
        private double Raduis { get; }

        #endregion

        /// <summary>
        /// Окружность
        /// </summary>
        /// <param name="raduis">Радиус окружности</param>
        /// <exception cref="ArgumentOutOfRangeException">Если радиус окружности имеет отрицательное значение</exception>
        public Circle(double raduis)
        {
            if(raduis < 0)
            {
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным значением");
            }

            Raduis = raduis;
        }

        #region Methods

        /// <summary>
        /// Вычесление площади окружности
        /// </summary>
        /// <returns>Возвращает площадь окружности</returns>
        public double CalculateSquare()
        {
            return Math.PI * Math.Pow(Raduis, 2);
        }

        #endregion
    }
}