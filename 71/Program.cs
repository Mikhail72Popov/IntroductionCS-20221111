// 71. Показать натуральные числа от N до 1, N задано

System.Console.Write("Введите число N=");
int n=Convert.ToInt32(Console.ReadLine());

void Recurs(int n,int i)
{
    if (n>=i)
    {
        System.Console.WriteLine(n);
        Recurs(n-i,i);
    }

}
Recurs(n,1);

