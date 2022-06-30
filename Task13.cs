Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) Console.WriteLine("Третьей цифры нет");
else 
{
    while (number > 999) //Сокращаем число до 3-х знаков
    {
        number = number / 10;
    }
    int result = number % 10;
    Console.WriteLine($"Третье число: {result}");
}