#region Using
using FigureLibrary;
#endregion

namespace TestFigures
{
    #region Class TriangleTests
    /// <summary>
    /// Тесты для класса Triangle на расчет площади
    /// </summary>
    public class TriangleTests
    {
        #region Public Methods

        /// <summary>
        /// Расчет площади треугольника с корректными параметрами при которых треугольник существует
        /// </summary>
        [Fact]
        public void CalculateSquarePositiveParamsExist()
        {
            Figure triangle = new Triangle(0.1, 0.1, 0.1);

            double result = triangle.CalculateSquare();

            Assert.True(result > 0);
        }

        /// <summary>
        /// Расчет площади треугольника с корректными параметрами при которых треугольник не существует
        /// </summary>
        [Fact]
        public void CalculateSquarePositiveParamsNotExist()
        {
            Figure triangle = new Triangle(0.1, 0.1, 0.2);

            double result = triangle.CalculateSquare();

            Assert.True(result == 0);
        }

        /// <summary>
        /// Расчет площади треугольника с одни нулевым параметром
        /// </summary>
        [Fact]
        public void CalculateSquareNullParam()
        { 
            Figure triangle = new Triangle(0, 0.1, 0.2);

            double result = triangle.CalculateSquare();

            Assert.True(result == 0);
        }

        /// <summary>
        /// Расчет площади треугольника с двумя нулевыми параметрами
        /// </summary>
        [Fact]
        public void CalculateSquareNullParams()
        {
            Figure triangle = new Triangle(0, 0.1, 0);

            double result = triangle.CalculateSquare();

            Assert.True(result == 0);
        }

        /// <summary>
        /// Расчет площади треугольника со всеми нулевыми параметрами
        /// </summary>
        [Fact]
        public void CalculateSquareNullAllParams()
        {
            Figure triangle = new Triangle(0, 0, 0);

            double result = triangle.CalculateSquare();

            Assert.True(result == 0);
        }

        /// <summary>
        /// Расчет площади треугольника с одним отрицательным параметром
        /// </summary>
        [Fact]
        public void CalculateSquareNegativeParam()
        {
            Figure triangle = new Triangle(-0.1, 0.1, 0.1);

            double result = triangle.CalculateSquare();

            Assert.True(result == 0);
        }

        /// <summary>
        /// Расчет площади треугольника с двумя отрицательными параметрами
        /// </summary>
        [Fact]
        public void CalculateSquareNegativeParams()
        {
            Figure triangle = new Triangle(-0.1, 0.1, -0.1);

            double result = triangle.CalculateSquare();

            Assert.True(result == 0);
        }

        /// <summary>
        /// Расчет площади треугольника со всеми отрицательными параметрами
        /// </summary>
        [Fact]
        public void CalculateSquareNegativeAllParams()
        {
            Figure triangle = new Triangle(-0.1, -0.1, -0.1);

            double result = triangle.CalculateSquare();

            Assert.True(result == 0);
        }
        #endregion
    }
    #endregion
}
