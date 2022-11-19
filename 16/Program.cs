// 16. Дано число. Проверить кратно ли оно 7 и 23
System.Console.WriteLine("Введите число");
int n=Convert.ToInt32(Console.ReadLine());
// вариат
// bool d1=n%7==0;
// bool d2=n%23==0;
if (n%7==0 && n%23==0)System.Console.WriteLine("YES"); else System.Console.WriteLine("NO");

