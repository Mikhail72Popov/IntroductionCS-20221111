// 2. С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго
System.Console.WriteLine("Введите число а:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введие число b:");
double b=Convert.ToDouble(Console.ReadLine());

if (a*a==b)
{
    System.Console.WriteLine($"{b} является квадратом {a}");
}
if (b*b==a)
{
     System.Console.WriteLine($"{a} является квадратом {b}");
}
if (a*a!=b && b*b!=a)
{
    System.Console.WriteLine($"{a} и {b} не являются квадратами друг друга");
}
