namespace SOLID
{
    public class RandomNumber : IRandomNumber<int>
    {
        public int GenerateValue(int minNumber, int maxNumber)
        {
            Random rand = new Random();
            return rand.Next(minNumber, maxNumber);
        }
    }
}
