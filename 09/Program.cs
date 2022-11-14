// 9. Вывести на экран четные числа от 1 до N
int N=Convert.ToInt32(Console.ReadLine());
int i=1;
// вид цикла
while(i<=N)
{
    System.Console.Write($"{i} ");
    i=i+1;
}
System.Console.WriteLine();
//или другая запись цикла
for(int j=1;j<=N;j++)
{
    System.Console.Write($"{j} ");
}
