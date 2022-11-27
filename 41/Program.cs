// 41. Задать массив из 8 элементов, заполненных нулями и единицами
// вывести их на экран

int[] RandomIntArray(int size=8)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(0,1);
    return a;
}
void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}
int[] m=RandomIntArray(8);
Print(m);
/*
int[] nums = new int[8] { 0, 1, 0, 1, 0, 1, 0, 1 };
Array.ForEach(nums,Console.Write );
*/
/*
void PrintMessage(string message)
{
    Console.Write(message);
}
PrintMessage("0, 1, 0, 1, 0, 1, 0, 1 ");
*/
