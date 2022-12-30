// 93: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/


Console.Write("введите количество строк массивов n=");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов массивов m=");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное число массивов min=");
int min=Convert.ToInt32(Console.ReadLine()); 
Console.Write("введите максимальное число массивов max=");
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
System.Console.WriteLine("Первый массив: ");
Print2DArray(a);
int[,] b=Random2DArray(n,m,min,max);
System.Console.WriteLine("Второй массив: ");
Print2DArray(b);


// Перемножение матриц
void Mult(int[,] a, int[,] b)
    {
        int[,] ab = new int[a.GetLength(0),a.GetLength(1)];                                                                       // int[,] ab= new [,];
             for (int i = 0; i < a.GetLength(0) && i < b.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1) && j < b.GetLength(1); j++)                                       
                {  
                    for (int q = 0; q < a.GetLength(0); q++)
                        for (int g = 0; g < a.GetLength(1); g++)
                            ab[i,j] = (a[i,j] * b[i,j]); 
                }
        Print2DArray(ab);  
    } 
System.Console.WriteLine("Произведение: ");
Mult(a, b);
