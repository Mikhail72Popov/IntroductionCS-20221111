// 45. Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел


Console.WriteLine("введите размерность массива");
int n=Convert.ToInt32(Console.ReadLine());
int[] RandomIntArray(int n)
   {
      int[] a=new int[n];
      Random random=new Random();
      for(int i=0;i<n;i++)
      a[i]=random.Next(100,999);
      return a;
   }

   void Print(int[] a)
    {
      for(int i=0;i<a.Length;i++)
      System.Console.WriteLine($"{a[i],5} ");
    }
  int[] z=RandomIntArray(n);


int Nhet(int[] m, int noh, int het, int n)  // подсчет нечетных/четных
  {
   for (int i = 0; i < n; i++)
      {
        if (m[i] % 2 != 0)
         ++noh;
        het = n-noh;
      } 
    Console.WriteLine($"{het} Количество четных чисел");
    Console.WriteLine($"{noh} Количество нечетных чисел"); 
    return noh; 
  }
  
Nhet( z, 0, 0, n); 
Console.WriteLine("Исходный массив: ");
Print(z);

