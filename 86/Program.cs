// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

System.Console.WriteLine("Введите строку ");
string s=Console.ReadLine();  
void Main(string s)
    {
        System.Console.WriteLine("Введите символ ");
        string let = Console.ReadLine(); 
        int count = s.Where(a => a.ToString() == let).ToList().Count();        
        Console.WriteLine(count);
    }        
Main(s); 