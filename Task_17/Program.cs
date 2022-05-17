// Программа принимает на вход координаты точки (X и Y), причем X не равен 0 и Y не равен 0
// и выдает номер четверти плоскости, в которой находится эта точка

Console.Write("Введите координату X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = int.Parse(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("Диапазон находится в 1 четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Диапазон находится во 2 четверти");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("Диапазон находится в 3 четверти");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("Диапазон находится в 4 четверти");
}
