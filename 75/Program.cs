// 75. Написать программу вычисления функции Аккермана

// функция Аккермана

System.Console.Write("Введите число n=");
uint n=Convert.ToUInt32(Console.ReadLine());
System.Console.Write("Введите число m=");
uint m=Convert.ToUInt32(Console.ReadLine());

static uint A(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}
System.Console.WriteLine(A(n, m));

/*
A(1, 2) = 4
A(0, 1) = 2
A(0, 0) = 1
A(2, 2) = 7
A(2, 3) = 9
A(3, 3) = 61
A(3, 4) = 125
A(4, 3) = ???????
*/