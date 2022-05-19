// Программа принимает на вход 5-значное число и проверяет
// является ли оно полиндромом

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int num1 = num / 10000;
int num2 = (num / 1000) % 10;
int num4 = (num / 10) % 10;
int num5 = num % 10;
if (num1 == num5 && num2 == num4) Console.WriteLine("Число является полиндромом");
else Console.WriteLine("Число не является полиндромом");



