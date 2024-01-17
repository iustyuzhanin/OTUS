namespace SOLID
{
    /// <summary>
    /// Угадывание чисел
    /// </summary>
    public class GuessNumber : IGuess<int>
    {
        public int Number { get; set; }

        public GuessNumber(int number)
        {
            Number = number;
        }

        public bool Check(int value)
        {
            if (Number > value)
                Console.WriteLine("Ваше число больше загаданного");

            else if (Number < value)
                Console.WriteLine("Ваше число меньше загаданного");

            else
            {
                Console.WriteLine("Поздравляем!!! Вы угадали число");
                return true;
            }

            return false;
        }
    }
}
