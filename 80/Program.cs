// 80. Вывести на экран кодировку символов по ASCII(с 32 до 122)

void Cod()
{
    for(char c='\x32';c<='\x122';c++)
    {
        System.Console.Write(c);
        System.Console.WriteLine();
    }
}
Cod();

/*
void Cod()
{
    for(char c=' ';c<='z';c++) // от 32-пробел до 122-z
    {
        System.Console.Write(c);
        System.Console.WriteLine();
    }
}
Cod();
*/