// 43. Написать программу замены элементов массива на противоположные

Console.WriteLine("введите размерность массива");
int n=int.Parse(Console.ReadLine()); 
int[] RandomIntArray(int n)
   {
      int[] a=new int[n];
      Random random=new Random();
      for(int i=0;i<n;i++)
      a[i]=random.Next(0,100);
      return a;
   }
void Print(int[] a)
   {
      for(int i=0;i<a.Length;i++)
      System.Console.WriteLine($"{a[i],5} ");
    }
  int[] m=RandomIntArray(n);

void Change(int[] a)
   {
      for (int i = 0; i < a.Length; ++i)
      if (a[i] > 0) a[i] = -a[i];
    }

Console.WriteLine("Исходный массив: ");
     Print(m);
     Change(m);
     
Console.WriteLine("Измененный массив: ");
     Print(m);
     


/*
    namespace ConsoleApplication2
    {
    class Class
      {
        static int [] Input ()
        {
          Console.WriteLine("введите размерность массива");
          int n=int.Parse(Console.ReadLine());
          int []a=new int[n];
          for (int i = 0; i < n; ++i) 
          {
            Console.Write("a[{0}]= ", i);
            a[i]=int.Parse(Console.ReadLine());
          }
          return a;
        }
     
        static void Print(int[] a) 
        {
          for (int i = 0; i < a.Length; ++i) Console.Write("{0} ", a[i]);
          Console.WriteLine();
        }
     
        static void Change(int[] a)
        {
          for (int i = 0; i < a.Length; ++i)
            if (a[i] > 0) a[i] = -a[i];
        }
     
        static void Main()
        {
          int[] myArray=Input();
    Console.WriteLine("Исходный массив:");
          Print(myArray);
          Change(myArray);
    Console.WriteLine("Измененный массив:");
          Print(myArray);
        }
      }
    }   
   */
