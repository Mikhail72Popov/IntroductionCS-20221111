// 31. Сгенирировать 10 случайных чисел. Показать кубы тех чисел,
// котрые заканчиваются на четную цифру.

/*int r=10;
double t=r; //не явное приведение типов
double x=23;
//int o=Convert.Toint32(x); можно так
int o=(int)x; // но лучше явное приведение типов
*/
// пдпрограмма:
bool Test(int a)
{
    //if (a%2==0) return true; else return false; или так
    return a*a*a%10%2==0;
}
Random random=new Random();
for(int i=0;i<5;i++)
{
    int a=random.Next(1,100);
    int b=a;//(int)Math.Pow(a,3);
    if (Test(b))
        System.Console.WriteLine($"{a}, {b}");
}
