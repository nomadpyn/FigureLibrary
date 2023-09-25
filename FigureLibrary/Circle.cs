
using System.Runtime.CompilerServices;

namespace FigureLibrary
{
    #region Class Circle
    /// <summary>
    /// Класс для создания круга по заданому радиусу 
    /// </summary>
    public class Circle : Figure
    {
        #region Private Fields
        public double Radius { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Конструктор с одним параметром (радиус)
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            Radius = radius;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Возвращает расчет площади круга, в случае неправильного значения радиуса возвращает 0
        /// </summary>
        /// <returns></returns>
        public override double CalculateSquare()
        {
            if(ValidateParameters())
            {
                return (Math.PI * Math.Pow(Radius,2));
            }
            return 0;
        }

        /// <summary>
        /// Перегрузка ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (ValidateParameters())
                return $"Круг с радиусом {Radius}";
            else
                return $"Параметры круга заданы неверно ({Radius}). Такого круга не существует";
        }
        #endregion

        #region Protected Methods
        /// <summary>
        /// Возвращает true, если значения радиус круга задан корректно и такой круг может существовать
        /// </summary>
        /// <returns></returns>
        protected override bool ValidateParameters()
        {
            if(Radius <= 0)
                return false;
            return true;
        }
        #endregion
    }
    #endregion
}
