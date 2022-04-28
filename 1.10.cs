using System;
class Program
{
    static void Main(string[] args)
    {
        double a, b, c, d, rez;
        Console.WriteLine("Введите значения для переменных");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        d = max(a, b);
        rez = max(d, c);
        Console.WriteLine("максимальное число равно" + rez);
        Console.ReadLine();
    }
    static double max(double x, double y)
    {
        if (x > y) return x;
        else return y;
    }
}
