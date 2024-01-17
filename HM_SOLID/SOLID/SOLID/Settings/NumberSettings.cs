namespace SOLID
{
    /// <summary>
    /// Настройки для чисел
    /// </summary>
    public class NumberSettings : Settings
    {
        /// <summary>
        /// Минимальное число
        /// </summary>
        public int MinNumber { get; set; }

        /// <summary>
        /// Максимальное число
        /// </summary>
        public int MaxNumber { get; set; }

        public NumberSettings(int minNumber, int maxNumber, int attemptsCount)
        {
            MinNumber = minNumber;
            MaxNumber = maxNumber;
            AttemptsCount = attemptsCount;
        }
    }
}
