namespace SOLID
{
    /// <summary>
    /// Настройки для букв
    /// </summary>
    public class LetterSettings : Settings
    {
        /// <summary>
        /// Минимальная буква
        /// </summary>
        public int Minletter { get; set; }

        /// <summary>
        /// Максимальная буква
        /// </summary>
        public int Maxletter { get; set; }

        public LetterSettings(char minLetter, int maxLetter, int attemptsCount)
        {
            Minletter = minLetter;
            Maxletter = maxLetter;
            AttemptsCount = attemptsCount;
        }
    }
}
