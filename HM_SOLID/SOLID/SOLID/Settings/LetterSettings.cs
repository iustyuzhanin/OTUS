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
        public char Minletter { get; set; }

        /// <summary>
        /// Максимальная буква
        /// </summary>
        public char Maxletter { get; set; }

        public LetterSettings(char minLetter, char maxLetter, int attemptsCount)
        {
            Minletter = minLetter;
            Maxletter = maxLetter;
            AttemptsCount = attemptsCount;
        }

        public override string GetSettings()
        {
            return $"Максимальная буква: {Maxletter}, Минимальная буква: {Minletter}, Количество попыток: {AttemptsCount}";
        }
    }
}
