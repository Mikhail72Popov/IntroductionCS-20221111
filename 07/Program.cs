// 7. Выяснить является ли число чётным.
System.Console.WriteLine("Введие число:");
double a=Convert.ToDouble(Console.ReadLine());
 if (a % 2 == 0)
{
    System.Console.WriteLine($"{a} четное число");
}
 if (a % 2 == 1)
{
    System.Console.WriteLine($"{a} не четное число");
}