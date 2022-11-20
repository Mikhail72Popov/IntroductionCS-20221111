// Агоритм Евклида
// без ппрограммы
/*int a=40;
int b=15;

while(a!=b)
    if (a>b)
        a=a-b;
    else
        b=b-a;
System.Console.WriteLine(a);
*/
// с подпограммой
/*int GCD(int a,int b)
{
    while(a!=b)
        if (a>b)
           a=a-b;
        else
           b=b-a;
    return a;
}
System.Console.WriteLine(GCD(15,20));
*/
// со счетчиком количества операций
int k=0;
int GCD(int a,int b)
{
    while(a!=b)
    {
        k++;
        if (a>b)
           a=a-b;
        else
           b=b-a;
    }
    return a;
}

//ускоренный алгоритм Евклида:

int QuicGCD(int a,int b)
{
    while(a!=0 && b!=0)
    {
        k++;
        if (a>b)
           a=a%b;
        else
           b=b%a;
    }
    return a+b;
}

System.Console.WriteLine(GCD(1,5000));
System.Console.WriteLine(k);
k=0;
System.Console.WriteLine(QuicGCD(1,5000));
System.Console.WriteLine(k);
