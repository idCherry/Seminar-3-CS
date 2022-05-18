// Программа на вход принимает число (N) и выдает таблицу квадратов чисел от 1 до N

Console.Write("Введите число -> ");
int n = int.Parse(Console.ReadLine());
int i = 1;

while (i <= n) 
{
    int res = i * i;
    Console.WriteLine($" Число {i, 5}| Квадрат числа {res, 5}" );
    i++;
}
