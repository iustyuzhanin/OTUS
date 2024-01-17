namespace SOLID
{
    public interface IRandomNumber<T>
    {
        /// <summary>
        /// Генерирует случайное целоцисленное значение
        /// </summary>
        /// <param name="minNumber">Минимальное значение</param>
        /// <param name="maxNumber">Максимальное значение</param>
        /// <returns></returns>
        T GenerateValue(int minNumber, int maxNumber);
    }
}
