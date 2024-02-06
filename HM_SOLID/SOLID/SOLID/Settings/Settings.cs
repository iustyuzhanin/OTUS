namespace SOLID
{
    /// <summary>
    /// Базовые настройки
    /// </summary>
    public abstract class Settings
    {
        /// <summary>
        /// Количество попыток
        /// </summary>
        public int AttemptsCount { get; set; }

        /// <summary>
        /// Выводит настроек
        /// </summary>
        /// <returns></returns>
        public abstract string GetSettings();
    }
}
