// 70. Показать натуральные числа от 1 до N, N задано

System.Console.Write("Введите число N=");
int n=Convert.ToInt32(Console.ReadLine());

void Recurs(int n, int i)
{
    if (i<=n)
     {
       System.Console.WriteLine(i);
       Recurs(n,i+1);
     }
}
Recurs(n,1);