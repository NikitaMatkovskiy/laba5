using System;
class Program
{
    static void Main(string[] args)
    {
        int a, b, x, y;
        Console.WriteLine("введите два натуральных числа");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        x = per(a);
        y = per(b);
        if (x > y) { Console.WriteLine("первая цифра числа {0} больше", a); }
        if (x < y) { Console.WriteLine("первая цифра числа {0} больше", b); }
        if (x == y) { Console.WriteLine("первые цифры одинаковые"); }
        Console.ReadLine();
    }
    static int per(int x)
    {
        int per = 0;
        do
        {
            per = x % 10;
            x /= 10;
        }
        while ((x % 10) != 0);

        return per;
    }

}
