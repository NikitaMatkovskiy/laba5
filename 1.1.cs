using System;
class Program
{
    static void Main(string[] args)
    {
        int x, y;
        bool a;
        Console.WriteLine("Введите значения для переменных x и y больше нуля");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        AddMul(x, y, out a);
        Console.ReadLine();
        Console.WriteLine("" + a);
    }
    static void AddMul(int x1, int y1, out bool a)
    {

        if (x1 % y1 == 0 || y1 % x1 == 0) { a = true; }
        else a = false;

    }
}
