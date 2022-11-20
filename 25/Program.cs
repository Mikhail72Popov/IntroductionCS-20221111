// 25. Вывести на экран кубы чисел от 1 до N
System.Console.WriteLine("Введите число N:");
int N=Convert.ToInt32(Console.ReadLine());
int i=1;
while(i<=N)
{
    System.Console.Write($"{i*i*i} ");
    i=i+1;
}


/*
int Cube(int i)
{
    cube=0;
    i=1;
     while(i<=N)
      {
         cube=i*i*i;
         i=i+1;
      }
    return cube;
}
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N:");
System.Console.WriteLine(Cube(N));
*/