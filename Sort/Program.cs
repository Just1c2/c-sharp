using System;

namespace Sort
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[5] { 10, 3, 21, 6, 1 };
            int i, j, temp;
            for (i = 0; i <= 5; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[i + 1] = temp;
            }
            Console.WriteLine("\nHien thi mang da duoc sap xep:\n");
            for(i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
        }
    }
}
