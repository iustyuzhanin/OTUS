namespace SOLID
{
    public interface IGuess<T>
    {
        /// <summary>
        /// Проверка на верность
        /// </summary>
        /// <param name="value">Загаданное значение</param>
        bool Check(T value);
    }
}
