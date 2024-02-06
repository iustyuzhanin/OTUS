// See https://aka.ms/new-console-template for more information
using SOLID;

Console.WriteLine("Угадай, число!");

var numberSettings = new NumberSettings(0, 100, 10);
var numberSettings2 = new NumberSettings(0, 50, 5);
var letterSettings = new LetterSettings('a', 'l', 100);

var settings = new Settings[] { numberSettings, numberSettings2, letterSettings };

foreach (var setting in settings)
{
    Console.WriteLine(setting.GetSettings());
} 

RandomNumber rand = new RandomNumber();
var randValue = rand.GenerateValue(numberSettings.MinNumber, numberSettings.MaxNumber);
var attempts = 0;
Console.WriteLine($"Диапазон: {numberSettings.MinNumber}-{numberSettings.MaxNumber}");

for (int i = numberSettings.MinNumber; i < numberSettings.MaxNumber; i++)
{
    Console.WriteLine($"\nУ вас попыток: {numberSettings.AttemptsCount-attempts}");
    Console.Write("Введите число: ");

    attempts++;
    int number = Convert.ToInt32(Console.ReadLine());
    var guessNumber = new GuessNumber(number); 
    var check = guessNumber.Check(randValue);

    if (check) break;
}

Console.ReadKey();



