using System;
class Program
{
    static void Main(string[] args)
    {
        double a, b, c, a1, b1, c1, sum, per;
        Console.WriteLine("Введите стороны первого треугольника");
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите стороны второго треугольника");
        a1 = Convert.ToDouble(Console.ReadLine());
        b1 = Convert.ToDouble(Console.ReadLine());
        c1 = Convert.ToDouble(Console.ReadLine());
        sum = sum1(a, b, c) + sum1(a1, b1, c1);
        per = Perimeter(a, b, c) + Perimeter(a1, b1, c1);
        Console.WriteLine("Сумма периметров = " + per);
        Console.WriteLine("Сумма площадей = " + sum);
        Console.ReadLine();
    }
    public static double sum1(double a2, double b2, double c2)
    {
        double p = (a2 + b2 + c2) / 2.0;
        return Math.Sqrt(p * (p - a2) * (p - b2) * (p - c2));
    }
    public static double Perimeter(double a2, double b2, double c2) => a2 + b2 + c2;
}
