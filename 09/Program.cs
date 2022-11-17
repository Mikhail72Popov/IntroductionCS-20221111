// 9. Вывести на экран четные числа от 1 до N
System.Console.WriteLine("Введите число:");
int N=Convert.ToInt32(Console.ReadLine());
int i=2;
// вид цикла
while(i<=N)
{
    System.Console.Write($"{i} ");
    i=i+2;
}
System.Console.WriteLine();
//или другая запись цикла
for(int j=2;j<=N;j=j+2)
{
    if (j%2==0)
    {
      System.Console.Write($"{j} ");
    }
    
}
