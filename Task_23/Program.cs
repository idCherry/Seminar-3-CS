// Программа принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N


Console.Write("Введите число -> ");
int n = int.Parse(Console.ReadLine());
int i = 1;

while (i <= n) 
{
    int res = i * i * i;
    Console.WriteLine($" Число {i, 7} | Куб числа {res, 7}" );
    i++;
}

