// 4. По заданному с клавиатуры номеру дня недели вывести его название
System.Console.WriteLine("Введите номер дня недели:");
double a=Convert.ToDouble(Console.ReadLine());

if (a==1)
{
    System.Console.WriteLine($"{a} - Понедельник");
}
if (a==2)
{
    System.Console.WriteLine($"{a} - Вторник");
}
if (a==3)
{
    System.Console.WriteLine($"{a} - Среда");
}
if (a==4)
{
    System.Console.WriteLine($"{a} - Четверг");
}
if (a==5)
{
    System.Console.WriteLine($"{a} - Пятница");
}
if (a==6)
{
    System.Console.WriteLine($"{a} - Суббота");
}
if (a==7)
{
    System.Console.WriteLine($"{a} - Воскесение");
}
if (a<1 || a>7)
{
    System.Console.WriteLine($"{a} - Номер не соответствует дню недели");
}
