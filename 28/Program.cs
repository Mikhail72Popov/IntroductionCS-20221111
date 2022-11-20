// 28. Определить количество цифр в числе. Сделать подпрограмму.
// 1 - без подпрограммы:
/*int N=Convert.ToInt32(Console.ReadLine());
N=Math.Abs(N);
int count=0;
if (N==0) count=1;
while (N>0)
{
    N=N/10;
    count++;
}
System.Console.WriteLine(count);
*/
// 2 - C подпограммой:
//подпрограмма:
int CountDigits(int Number)
{
    Number=Math.Abs(Number);
    int count=0;
    if (Number==0) count=1;
    while (Number>0)
    {
    Number=Number/10;
    count++;
    }
    return count;
}

//основная программа:
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CountDigits(N));

