#region Using
using FigureLibrary;
#endregion

namespace TestFigures
{
    #region Class CircleTests
    /// <summary>
    /// Тесты для класса Circle на расчет площади
    /// </summary>
    public class CircleTests 
    {
        #region Public Methods

        /// <summary>
        /// Расчет площади круга при корректном радиусе - ждем больше 0 
        /// </summary>
        [Fact]
        public void CalculateSquarePositiveRadius()
        {
            Figure circle = new Circle(0.1);

            double result = circle.CalculateSquare();

            Assert.True(result > 0);
        }

        /// <summary>
        /// Расчет площади круга при отрицательном радиусе - ждем 0
        /// </summary>
        [Fact]
        public void CalculateSquareNegativeRadius() 
        {
            Figure circle = new Circle(-0.1);

            double result = circle.CalculateSquare();

            Assert.True(result == 0);
        }

        /// <summary>
        /// Расчет прощади круга при нулевом радиусе - ждем 0
        /// </summary>
        [Fact]
        public void CalculateSquareNullRadius()
        {
            Figure circle = new Circle(0);

            double result = circle.CalculateSquare();

            Assert.True(result == 0);
        }

        /// <summary>
        /// Расчет площади круга при радиусе 5 - ждем значение 78.53981633974483
        /// </summary>
        [Fact]
        public void CalculateSquareSomeRadius()
        {
            Figure circle = new Circle(5);

            double result = circle.CalculateSquare();

            Assert.True(result == 78.53981633974483);
        }
        #endregion
    }
    #endregion
}