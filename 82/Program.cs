// 82. C клавиатуры вводится строка разделенная точкой.
// Подсчитать количество символов до точки

System.Console.Write("Введите строку ");
string s=Console.ReadLine();
void Simv()
    {
        int k=0;
        for(int i=0;i<s.Length;i++)
            if ( s[i]!='.') k++; 
            else
        System.Console.WriteLine($"Количество символов до точки = {k}");
    }
Simv();