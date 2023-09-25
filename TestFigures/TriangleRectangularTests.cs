#region Using
using FigureLibrary;
#endregion

namespace TestFigures
{
    #region Class TriangleRectangularTests
    /// <summary>
    /// Класс для проверки треугольника на то, является ли он прямоугольным
    /// </summary>
    public class TriangleRectangularTests
    {
        #region Public Methods

        /// <summary>
        /// Возвращает true, если треугольник может существовать и он прямоугольный
        /// </summary>
        [Fact]
        public void IsTriangleRectangularExistIsRectangular()
        {
            Figure figure = new Triangle(5, 12, 13);

            bool result = Triangle.IsTriangleRectangular((Triangle)figure);

            Assert.True(result);
        }              

        /// <summary>
        /// Возвращает false, если треугольник может существовать и он не прямоугольный
        /// </summary>
        [Fact]
        public void IsTriangleRectangularExistNotRectangular()
        {
            Figure figure = new Triangle(5, 10, 13);

            bool result = Triangle.IsTriangleRectangular((Triangle)figure);

            Assert.False(result);
        }

        /// <summary>
        /// Возвращает false, если треугольник не существует
        /// </summary>
        [Fact]
        public void IsTriangleRectangularNotExist()
        {
            Figure figure = new Triangle(5, 1, 13);

            bool result = Triangle.IsTriangleRectangular((Triangle)figure);

            Assert.False(result);
        }

        /// <summary>
        /// Возвращает false, если передан треугольник со значением null
        /// </summary>
        [Fact]
        public void IsTriangleRectangularNull()
        {
            Triangle triangle = null;

            bool result = Triangle.IsTriangleRectangular(triangle);

            Assert.False(result);
        }

        #endregion
    }
    #endregion
}
