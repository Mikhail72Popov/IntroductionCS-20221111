// 61. Показать двумерный массив размером m×n
// заполненный вещественными случайными числами


Console.Write("введите количество строк массива n=");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов массива m=");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное число массива min=");
int min=Convert.ToInt32(Console.ReadLine()); 
Console.Write("введите максимальное число массива max=");
int max=Convert.ToInt32(Console.ReadLine());

double[,] Random2DArray(int n,int m,int min,int max)
{
    double[,] a= new double[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
        a[i,j]=Math.Round(random.NextDouble()*random.Next(min,max),2);
    return a;
}

void Print2DArray(double[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],10}");
           System.Console.WriteLine();
        }
}
double[,] a=Random2DArray(n,m,min,max);
Print2DArray(a);