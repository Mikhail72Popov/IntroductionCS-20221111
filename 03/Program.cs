// 3. С клавиатуры вводя два числа a и b. Найти максимальное из них.
System.Console.WriteLine("Введите число а:");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введие число b:");
int b=Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    System.Console.WriteLine($"{a} Максимальное число");
}
else
{
    System.Console.WriteLine($"{b} Максимальное число");
}


