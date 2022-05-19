// Программа на вход принимает координаты двух точек и находит расстояние
// между ними в 3D пространстве

Console.WriteLine("Введите координаты первой точки: ");
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double z2 = double.Parse(Console.ReadLine());

double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
double n = Math.Round(distance, 2);
Console.WriteLine($"Расстояние между точками в 3D пространстве: {n}");
