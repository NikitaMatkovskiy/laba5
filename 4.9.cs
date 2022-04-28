using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1-й массив:");
        int[] A = Create();
        Console.WriteLine("2-й массив:");
        int[] B = Create();
        int x = KolArr(A);
        int y = KolArr(B);
        if (x > y)
        {
            Console.WriteLine("массив имеющий наибольшее количество положительных элементов");
            PrintArray(A);
            Console.WriteLine("массив имеющий наименьшее количество положительных элементов");
            PrintArray(B);
        }
        if (y > x)
        {
            Console.WriteLine("массив имеющий наибольшее количество положительных элементов");
            PrintArray(B);
            Console.WriteLine("массив имеющий наименьшее количество положительных элементов");
            PrintArray(A);
        }
        Console.ReadLine();

    }
    static int[] Create()
    {
        Console.WriteLine("Введите количество элементов массива");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Введите элементы массива");
        for (int i = 0; i < n; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());
        return arr;
    }
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write("{0} ", arr[i]);
        Console.WriteLine();
    }
    static int KolArr(int[] arr)
    {
        int kol = 0;
        for (int i = 1; i < arr.Length; i++)
            if (arr[i] > 0)
            {
                kol++;
            }
        return kol;
    }

}
