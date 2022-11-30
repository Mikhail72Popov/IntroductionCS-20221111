// 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи.
// Принять первые числа равными 0 и 1

Console.WriteLine("До какого числа считать ряд Фибоначчи?");
int n = Convert.ToInt32(Console.ReadLine());

double Fibonacci(int n)  // для больших чисел использовать double
{
    if (n == 1 || n ==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);

}
for (int i=1; i<n; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}


/*
int n=10;
int[] a=new int[n];
a[0]=0;
a[1]=1;
for(int i=2;i<n;i++)
  a[i]=a[i-1]+a[i-2];//рекурентная формула (следующее значение за счет использования предыдущих)
for(int i=0;i<n;i++)
    System.Console.Write($"{a[i]} ");

*/