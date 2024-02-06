namespace SOLID
{
    public class RandomNumber : IRandom<int>
    {
        public int GenerateValue(int minNumber, int maxNumber)
        {
            Random rand = new Random();
            return rand.Next(minNumber, maxNumber);
        }
    }
}
