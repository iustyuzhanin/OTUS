namespace SOLID
{
    public interface IRandom<T> : IRandomNumber<T>, IRandomLetter<T>
    {
        /// <summary>
        /// Генерирует случайное значение
        /// </summary>
        T GenerateValue();
    }
}
