Console.Write("Введите номер дня недели: ");
int week = Convert.ToInt32(Console.ReadLine());
if (week > 0 && week < 8)
{
    if (week == 6 || week == 7)
    {
        Console.Write("Ура, сегодня выходной!");
    }
    else Console.Write("Похоже, сегодня на работу =(");
}
else Console.Write("Такого дня не бывает");