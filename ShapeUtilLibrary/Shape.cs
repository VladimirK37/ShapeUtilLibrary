namespace ShapeUtilLibrary
{
    /// <summary>
    ///  Класс для работы с фигурами 
    /// </summary>
    public abstract class Shape : IValidatable
    {
        /// <summary>
        /// Получение площади фигуры 
        /// </summary>
        public abstract double GetArea();

        /// <summary>
        /// Проверка достоверности
        /// </summary>
        public abstract bool IsValid();
    }
}
