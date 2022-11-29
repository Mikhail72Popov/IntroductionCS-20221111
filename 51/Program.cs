// 51. С клавиатуры вводится число N. Затем вводятся N чисел.
// Определить сколько чисел больше 0 введено с клавиатуры



Console.Write("Введите число N: ");  
int q = Convert.ToInt32( Console.ReadLine() );
int Number (int n=0)
{
  int z = 0;
  for (int i=0 ; i<n; i = i + 1)
    {    
        Console.WriteLine("Введите число: "); 
        int a = Convert.ToInt32( Console.ReadLine());
        if (a>0) z = z+1; 
    }   return z;    
} 

Console.WriteLine("Больше ноля = {0}", (Number(q)));




/*
    Console.WriteLine("Введите число N");  
            int n = Convert.ToInt32( Console.ReadLine() );
            int pr = 0;
            for (int i=0;i<n;i++)
            {
                Console.WriteLine("Введите число: "); 
                int a = Convert.ToInt32( Console.ReadLine() );
                if (a>0) pr = pr + 1;
            }
            Console.WriteLine("Больше ноля = {0}", pr);
            */
