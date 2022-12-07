/*
string s = "asdf";// обозначает ссылку на объект
// immutable string (не изменяемые строки)
System.Console.WriteLine(s[0]);
for(int i=0;i<s.Length;i++)       // поиск элемента строки по индексу, на подобии массива
    System.Console.WriteLine(s[i]);
 // но присваивать новые индексы в строке нельзя
 
 
 // для разборки строки или замены элемента в строке:
 char[] cc=s.ToCharArray(); // преобразование в  char
cc[0]='$'; // изменения с элементами
s=new String(cc); // преобразование обратно в строку
// или
System.Text.StringBuilder sb=new System.Text.StringBuilder("asdf");
sb[0]='s';
// и обратно
s=sb.ToString();
// пример отбора
for(int i=0;i<1000000;i++)
    s=s+"1"; //создается новая строка!
    // или
for(int i=0;i<1000000;i++)
    sb.Append("1");


// s1.Length операция замены
s2=s1.Substring(2,4);
System.Console.WriteLine(s1.IndexOf("as"));
s1=s2.Replace("ab","ba");
*/


//ReadLn(a,b,c) сздание строчки в паскале
//10 20 30

// в C#:
/*string s=Console.ReadLine(); // ввод
string[] ss=s.Split(' '); // разделение на 10, 20, 30
int[] n=new int[ss.Length]; //создание массива чисел
for(int i=0;i<ss.Length;i++) //цикл
  n[i]=Convert.ToInt32(ss[i]); // сонвертировать в n каждый элемент
int a=n[0];
int b=n[1];
int c=n[2];
*/
// или более коротко
string[] ss=Console.ReadLine().Split(' ');
int[] n=Array.ConvertAll<string,int>(ss,Convert.ToInt32);//обобщенные типы и параметризированные методы
int a=n[0];
int b=n[1];
int c=n[2];
