// Программа по заданному номеру четверти показывает диапазон возможных координат 
// точек в этой четверти (X и Y)

Console.Write("Введите четверть диапазона: ");
int num = int.Parse(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("Диапазон координат: x > 0 и y > 0");
}
else if (num == 2)
{
    Console.WriteLine("Диапазон координат: x < 0 и y > 0 ");
}
else if (num == 3)
{
    Console.WriteLine("Диапазон координат: x < 0 и y < 0");
}
else if (num == 4)
{
    Console.WriteLine("Диапазон координат: x > 0 и y < 0");
}
else Console.WriteLine("Введены невенрные данные");