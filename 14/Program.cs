// 14. С клавиатуры вводятся два числа a и b.
// Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
System.Console.WriteLine("Введите число а:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введие число b:");
double b=Convert.ToDouble(Console.ReadLine());
if (a%b==0)
{
    System.Console.WriteLine($"{a} Кратно числу {b}");
}
else
{
    System.Console.WriteLine($"{a%b} Остаток деления a/b");
}