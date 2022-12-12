//87. Удалить среднюю букву при нечетное длине строки и две средние буквы при четной длине строки
System.Console.WriteLine("Ведите строку");
string s=Console.ReadLine();
string s1;
int m=s.Length/2;
if (s.Length%2==0)
{
    s1=s.Remove(m-1,2);
}
else
{
    s1=s.Remove(m,1);
}
System.Console.WriteLine(s1);