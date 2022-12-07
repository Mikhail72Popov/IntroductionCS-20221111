// char хранит один символ в UTF-16

using System.Linq;

char c='a'; // одинанарные ковычки system char
// char c="a" // двойные ковычки system string
c='\x64'; // обозначение символа через код
c='\u0064'; // через юникод
char b='a';
System.Console.WriteLine((int)b);
System.Console.WriteLine(c.ToString()+b.ToString()); //склеивание символов а и b
if (b>='0' && b<='9') System.Console.WriteLine("It's digit"); //проверка символа  
if (b>='A' && b<='Z') System.Console.WriteLine("It's big Latin");
if (b>='a' && b<='z' || b>='A' && b<='Z') System.Console.WriteLine("It's big Latin");

if (Char.IsDigit(b)) System.Console.WriteLine("It's digit"); // метод проверки символа
// на цифру