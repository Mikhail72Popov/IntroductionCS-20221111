// 46. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Console.WriteLine("введите размерность массива");
int size=Convert.ToInt32(Console.ReadLine()); 

int[] RandomIntArray(int size=123,int min=-100,int max=100)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

int Selection(int[] a)
{
  Console.WriteLine(" введите min");
  int n=Convert.ToInt32(Console.ReadLine());  // вводим с клавиатуры  min
  Console.WriteLine(" введите max");
  int m=Convert.ToInt32(Console.ReadLine()); // вводим с клавиатуры max
  int count = 0;
  {
     for (int i = 0; i < size; i++) 
     if (a[i] >= n && a[i] <= m) count=count+1;  // считаем кол-во элементов a[i] в диапазоне
         
  }  
   return count; 
}    

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],5}");
}

int[] a=RandomIntArray(size,-100,100);
Print(a);

int s=Selection(a);
System.Console.WriteLine($"{s} элемента в диапазоне ");

System.Console.WriteLine();
