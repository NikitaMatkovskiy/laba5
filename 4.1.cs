using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1-й массив:");
        int[] A = Create();
        Console.WriteLine("2-й массив:");
        int[] B = Create();
        int x = SumArr(A);
        int y = SumArr(B);
        if (x > y)
        {
            Console.WriteLine("массив с наименьшей суммой");
            PrintArray(B);
            Console.WriteLine("массив с наибольшей суммой");
            PrintArray(A);
        }
        if (y > x)
        {
            Console.WriteLine("массив с наименьшей суммой");
            PrintArray(A);
            Console.WriteLine("массив с наибольшей суммой");
            PrintArray(B);
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
    static int SumArr(int[] arr)
    {
        int sum = 0;
        for (int i = 1; i < arr.Length; i++)
            sum += arr[i];
        return sum;
    }

}
