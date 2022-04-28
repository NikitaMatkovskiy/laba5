using System;
class Program
{
    static void Main(string[] args)
    {
        double a1, b1, h1, a2, b2, h2, sum;
        Console.WriteLine("введите основания первой трапеции и высоту через Enter");
        a1 = Convert.ToDouble(Console.ReadLine());
        b1 = Convert.ToDouble(Console.ReadLine());
        h1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("введите основания второй трапеции и высоту через Enter");
        a2 = Convert.ToDouble(Console.ReadLine());
        b2 = Convert.ToDouble(Console.ReadLine());
        h2 = Convert.ToDouble(Console.ReadLine());
        sum = sum1(a1, b1, h1) + sum1(a2, b2, h2);
        Console.WriteLine("Сумма площадей = " + sum);
        Console.ReadLine();
    }
    public static double sum1(double a, double b, double h)
    {
        double c = 0.5;
        return c * h * (a + b);
    }
}
