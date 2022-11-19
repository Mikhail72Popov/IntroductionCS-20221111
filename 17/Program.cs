// 17. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
System.Console.WriteLine("Введите номер дня недели:");
double a=Convert.ToDouble(Console.ReadLine());
if (a==6 || a==7)
{
    System.Console.WriteLine($"{a} - Выходной");
}
if (a<1 || a>7)
{
    System.Console.WriteLine($"{a} - Номер не соответствует дню недели");
}
if (a<6 && a>0)
{
    System.Console.WriteLine($"{a} - Рабочий день");
}