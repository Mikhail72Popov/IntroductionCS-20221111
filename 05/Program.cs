//5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел
System.Console.WriteLine("Введите число а:");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введие число b:");
int b=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введие число c:");
int c=Convert.ToInt32(Console.ReadLine());

if (a>b & a>c)
{
    System.Console.WriteLine($"{a} Максимальное число");
}
if (b>a & b>c)
{
     System.Console.WriteLine($"{b} Максимальное число");
};
if (c>a & b<c)
{
     System.Console.WriteLine($"{c} Максимальное число");
}
