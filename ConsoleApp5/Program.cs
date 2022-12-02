using System;

public class Example
{
    public static void Main()
    {
        int[] arr = { 8, 3, 5, -1, 2 };

        Array.Sort(arr);
        if (arr.Length > 0)
        {
            Console.WriteLine("Минимальное число из последовательности чисел " + arr[0]);
            Console.ReadKey();
        }
    }
}
