// 25. Вывести на экран кубы чисел от 1 до N
/*System.Console.WriteLine("Введите число N:");
int N=Convert.ToInt32(Console.ReadLine());
int i=1;
while(i<=N)
{
    System.Console.Write($"{i*i*i} ");
    i=i+1;
}
*/


int Cube(int N)
{
    int i=1, p=1;
    while(i<=N)
    {
      p = i*i*i;
      i=i+1;
    }
    return p;
}
System.Console.Write("Введите число n: ");
int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Cube(n));
