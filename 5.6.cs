using System;
class Program
{
    
    static void Main(string[] args)
    {
        Console.Write("Введите искомый номер прогрессии n= ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите первый член прогрессии b= ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите знаменатель прогрессии q= ");
        int q = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine("{0}",ngp(b,n,q)); 
        
        Console.ReadLine();
    }

    static long ngp(int b, int n, int q)
    {
        if (b == 1)
        {
            return n;
        }
        else if (b == 2)
        {
            return n * q;
        }
        else
        {
            return q * ngp(b - 1, n, q);
        }
    }

}