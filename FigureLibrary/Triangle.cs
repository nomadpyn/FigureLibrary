
namespace FigureLibrary
{
    #region Class Triangle
    /// <summary>
    /// Класс для создания треугольника по трем сторонам
    /// </summary>
    public class Triangle : Figure
    {
        #region Public Fields
        public double SideA { get; set; }
        public double SideB{ get; set; }
        public double SideC{ get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Конструктор с тремя параметрами (три стороны треугольника)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;            
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Возвращает расчет площади треугольника, в случае неправильных значений сторон возвращает 0
        /// </summary>
        /// <returns></returns>
        public override double CalculateSquare()
        {
            if (ValidateParameters())
            {
                double perimeter = (SideA + SideB + SideC) / 2;

                return Math.Sqrt(perimeter * (perimeter - SideA) * (perimeter - SideB) * (perimeter - SideC));
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
            {
                return $"Треугольник со сторонами {SideA} : {SideB} : {SideC}";
            }
            else
            {
                return $"Параметры треугольника заданы не верно ({SideA} : {SideB} : {SideC}), такого треугольника не существует";
            }
        }

        #endregion

        #region Static Public Methods
        /// <summary>
        /// Возвращает true, если треугольник прямоугольный (Теорема Пифагора)
        /// </summary>
        /// <returns></returns>
        public static bool IsTriangleRectangular(Triangle checkTriangle)
        {
            if (checkTriangle != null)
            {
                if (checkTriangle.ValidateParameters())
                {
                    if ((Math.Pow(checkTriangle.SideA, 2) == Math.Pow(checkTriangle.SideB, 2) + Math.Pow(checkTriangle.SideC, 2)) ||
                       (Math.Pow(checkTriangle.SideB, 2) == Math.Pow(checkTriangle.SideA, 2) + Math.Pow(checkTriangle.SideC, 2)) ||
                       (Math.Pow(checkTriangle.SideC, 2) == Math.Pow(checkTriangle.SideA, 2) + Math.Pow(checkTriangle.SideB, 2)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion

        #region Protected Methods
        /// <summary>
        /// Возвращает true, если значения сторон треугольника заданы корректно и треугольник может существовать
        /// </summary>
        /// <returns></returns>
        protected override bool ValidateParameters()
        {
            if (ValidateOneParam(SideA) && ValidateOneParam(SideB) && ValidateOneParam(SideC))
            {
                if (CheckTriangle())
                    return true;
                else 
                    return false;
            }
            else
                return false;
        }
        
        /// <summary>
        /// Возвращает true, если параметр (сторона треугольника) задан корректно
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        protected bool ValidateOneParam(double param)
        {
            if (param <= 0)
                return false;
            return true;
        }

        /// <summary>
        /// Возвращает true, если треугольник с задаными сторонами может существовать
        /// </summary>
        /// <returns></returns>
        protected bool CheckTriangle()
        {
            if ((SideA > SideB + SideC) || (SideB > SideA + SideC) || (SideC > SideA + SideB))
                return false;
            else 
                return true;
        }
        #endregion
    }
    #endregion
}
