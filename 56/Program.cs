// 56. Написать программу копирования массива

Console.Write("введите размерность массива: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" введите min");
int min=Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(" введите max");
int max=Convert.ToInt32(Console.ReadLine());
int[] RandomIntArray(int size=5,int min=-10,int max=10)
    {
     int[] a=new int[size];
     Random random=new Random();
     for(int i=0;i<size;i++)
     a[i]=random.Next(min,max+1);
     return a;
    }
Console.WriteLine(" исходный:"); 
void Print(int[] a)
    {
     for(int i=0;i<a.Length;i++)
     System.Console.Write($"{a[i],3}");
    }
int[] a=RandomIntArray(size,-10,10);
Print(a);
//public class Example

static void Main(int[] a)
    { 
     int[] copy = new int[a.Length];
     Array.Copy(a, copy, a.Length);
     Console.WriteLine();
     Console.WriteLine(" копия: ");
     Console.WriteLine(String.Join( "  ",  copy));     
    }

Main(a);












/*
using System;
 
public class Example
{
    public static void Main()
    {
        int[] arr = { 5, 4, 7, 2, 9 };
 
        int[] copy = new int[arr.Length];
        arr.CopyTo(copy, 0);
 
        Console.WriteLine(String.Join(", ", copy));        // 5, 4, 7, 2, 9
    }
}
*/