// 8. Вывести на экран числа от -N до N
System.Console.WriteLine("Введите положительное число N:");
int N=Convert.ToInt32(Console.ReadLine());
int i=-N;
// вид цикла
while(i<=N)
{
    System.Console.Write($"{i} ");
    i=i+1;
}
System.Console.WriteLine();
//или другая запись цикла
for(int j=-N;j<=N;j++)
{
    System.Console.Write($"{j} ");
}
/* или так:
int N=Convert.ToInt32(Console.ReadLine());
for(int i=-N;i<=N;i++)
System.Console.Write($"{i} ");
*/