int n=Convert.ToInt32(Console.ReadLine());
//int n=int.Parse(Console.ReadLine()); -можно так
int k=0;//Счетчик
bool flag=false;//флаг
for(int i=0;i<n;i++)
{
    int a=Convert.ToInt32(Console.ReadLine());
    //int a=int.Parse(Console.ReadLine()); -можно так
    if (a<5) k++;
    if (a==10) flag=true;
}
System.Console.WriteLine(k);
if (flag==true) System.Console.WriteLine("YES"); else System.Console.WriteLine("NO");
//или можно так:
// if (flag) System.Console.WriteLine("YES"); else System.Console.WriteLine("NO");


