using System;
class Program
{

    static void Main(string[] args)
    {
        Console.Write("Введите x = ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите n = ");
        double n = Convert.ToDouble(Console.ReadLine());
        if (x < 0)
        {
            Console.WriteLine("x<0");
        }
        if (x > 0)
        {
            Console.WriteLine("{0}", Task(x, n));
        }
        Console.ReadLine();
    }

    static public double Task(double x, double n)
    {

        if (n == 0) return 0;
        else if (n < 0) return Math.Pow(x, n);
        else if (n > 0) return x * Math.Pow(x, n - 1);
        return x;

    }

}
