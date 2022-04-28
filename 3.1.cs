using System;
class Program
{
    static void Main(string[] args)
    {
        int a, b, x, y;
        Console.WriteLine("введите два натуральных числа");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        x = sum(a);
        y = sum(b);
        if (x > y) { Console.WriteLine("сумма цифр {0} больше", a); }
        if (x < y) { Console.WriteLine("сумма цифр {0} больше", b); }
        if (x == y) { Console.WriteLine("сумма цифр одинакова"); }
        Console.ReadLine();
    }
    static int sum(int a1)
    {
        int suma = 0;
        do
        {
            suma += a1 % 10;
            a1 /= 10;
        }
        while ((a1 % 10) != 0);
        return suma;
    }

}
