// 62. В двумерном массиве n×m заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j])

Console.Write("введите количество строк массива n=");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов массива m=");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное число массива min=");
int min=Convert.ToInt32(Console.ReadLine()); 
Console.Write("введите максимальное число массива max=");
int max=Convert.ToInt32(Console.ReadLine());

int[,] Random2DArray(int n,int m,int min,int max)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
         for(int j=0;j<a.GetLength(1);j++)
           System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
}
int[,] a=Random2DArray(n,m,min,max);
System.Console.WriteLine("Первоначальный массив: ");
Print2DArray(a);
System.Console.WriteLine("Изменённый массив: ");


// отбор четных чисел и замена на противоположное значение
void EvenNumber(int[,] a)
{
    for(int j=0;j<a.GetLength(1);j++)    
        for(int k=0;k<a.GetLength(0);k++)
            for(int i=0;i<a.GetLength(0);i++)
                if (a[i,j]%2==0)
                {
                  a[i,j]=-a[i,j];                      
                }
}

EvenNumber(a);
Print2DArray(a);
