// See https://aka.ms/new-console-template for more information
using SOLID;

Console.WriteLine("Угадай, число!");

var settings = new NumberSettings(0, 100, 10);
RandomNumber rand = new RandomNumber();
var randValue = rand.GenerateValue(settings.MinNumber, settings.MaxNumber);
var attempts = 0;
Console.WriteLine($"Диапазон: {settings.MinNumber}-{settings.MaxNumber}");

for (int i = settings.MinNumber; i < settings.MaxNumber; i++)
{
    Console.WriteLine($"\nУ вас попыток: {settings.AttemptsCount-attempts}");
    Console.Write("Введите число: ");

    attempts++;
    int number = Convert.ToInt32(Console.ReadLine());
    var guessNumber = new GuessNumber(number);
    var check = guessNumber.Check(randValue);

    if (check) break;
}

Console.ReadKey();



