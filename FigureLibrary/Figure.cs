namespace FigureLibrary
{
    #region Class Figure 
    /// <summary>
    /// Абстрактный класс для создания фигуры
    /// </summary>
    public abstract class Figure
    {
        #region Public Methods
        /// <summary>
        /// Абстрактный метод расчет площади
        /// </summary>
        /// <returns></returns>
        public abstract double CalculateSquare();
        #endregion

        #region Protected Methods
        /// <summary>
        /// Абстрактный метод проверки параметров фигуры на корректность
        /// </summary>
        /// <returns></returns>
        protected abstract bool ValidateParameters();
        #endregion
    }
    #endregion
}