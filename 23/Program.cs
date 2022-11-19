// 23. Найти расстояние между точками в пространстве 2D
double x1,y1,x2,y2,distance;
Console.WriteLine("Введите координаты x1");
x1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты y1");
y1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты x2");
x2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты y2");
y2=Convert.ToDouble(Console.ReadLine());
distance=Math.Sqrt((x2-x1)*(x2-x1)+Math.Sqrt((y2-y1)*(y2-y1)));
//или distance=Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
System.Console.WriteLine(distance);
