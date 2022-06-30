Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int digit2 = number / 10; // из трехзначного числа получаем двухзначное
    int digit1 = digit2 % 10;
    Console.WriteLine(digit1);
}
else Console.WriteLine("Число не трехзначное");