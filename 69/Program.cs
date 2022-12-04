// 69. Написать программу, упорядочивания по /убыванию?/ элементы каждой строки двумерного массива.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/

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

// Сортировка по возрастанию (в соответсвии примера)
void AscendingSorting(int[,] a)
{
  for (int i = 0; i < a.GetLength(0); i++)
    for (int j = 0; j < a.GetLength(1); j++) 
      for (int k = 0; k < a.GetLength(1) - 1; k++)     
        if (a[i, k] > a[i, k + 1])
        {
          int temp = a[i, k];
          a[i, k] = a[i, k + 1];
          a[i, k + 1] = temp;
        }  
}

// Сортировка по убыванию
void SortDescending(int[,] a)
{
  for (int i = 0; i < a.GetLength(0); i++)
    for (int j = 0; j < a.GetLength(1); j++)
      for (int k = 0; k < a.GetLength(1) - 1; k++)
        if (a[i, k] < a[i, k + 1])
        {
          int temp = a[i, k + 1];
          a[i, k + 1] = a[i, k];
          a[i, k] = temp;
        }
}

AscendingSorting(a);
System.Console.WriteLine("Возрастание: ");
Print2DArray(a);

SortDescending(a);
System.Console.WriteLine("Убывание: ");
Print2DArray(a);



