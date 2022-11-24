// 30. Написать программу вычисления произведения чисел от 1 до N

int Cube(int N)
{
    int p=1, j=0;
    while(j<N)
    {
      p = p*(j+1);
      j=j+1;
    }
    return p;
}
System.Console.Write("Введите число => 1 : ");
int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Cube(n));