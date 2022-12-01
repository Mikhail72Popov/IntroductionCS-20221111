// 61. Показать двумерный массив размером m×n
// заполненный вещественными случайными числами


Console.Write("введите количество строк массива n=");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов массива m=");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное число массива min=");
double min=Convert.ToDouble(Console.ReadLine()); 
Console.Write("введите максимальное число массива max=");
double max=Convert.ToDouble(Console.ReadLine());

double[,] Random2DArray(int n,int m,double min=0,double max=10)
{
    double[,] a= new double[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
        a[i,j]=random.Next(min,max+1);
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