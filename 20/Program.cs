// 20. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
/*Если точка имеет положительную координату x и положительную координату y, то она лежит в I четверти.
Если точка имеет отрицательную координату x и положительную координату y, то она лежит во II четверти.
Если точка имеет отрицательную координату x и отрицательную координату y, то она лежит в III четверти.
Если точка имеет положительную координату x и отрицательную координату y, то она лежит в IV четверти
*/
double x,y;
Console.WriteLine("Введите координату x");
x=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y");
y=Convert.ToDouble(Console.ReadLine());
if (x>0 && y>0)
{
    System.Console.WriteLine("Точка находится в I четверти");
}
if (x<0 && y>0)
{
    System.Console.WriteLine("Точка находится во II четверти");
}
if (x<0 && y<0)
{
    System.Console.WriteLine("Точка находится в III четверти");
}
if (x>0 && y<0)
{
    System.Console.WriteLine("Точка находится в IV четверти");
}
/* или другой вариант:
double x=Convert.ToDouble(Console.ReadLine());
double y=Convert.ToDouble(Console.ReadLine());
int part=0;
if (x>0 && y>0) part=1;
if (x<0 && y>0) part=2;
if (x<0 && y<0) part=3;
if (x>0 && y<0) part=4;
System.Console.WriteLine("Part:"+part);
*/