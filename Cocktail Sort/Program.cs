using System;

class Program
{
    static void Main(int[] array)
    {
        Console.WriteLine("Hello, World!");
        int[] unsorted = { 204, 12, 112, 143, 234, 5433, 234, 234, 543, 322, 41, 13, 46, 76, 34 };

        bool swapped = true;
        int start = 0;
        int end = unsorted.Length - 1;

        while (swapped)
        {
            swapped = false;

            // Forward pass
            for (int i = start; i < end; i++)
            {
                if (unsorted[i] > unsorted[i + 1])
                {
                    int temp = unsorted[i];
                    unsorted[i] = unsorted[i + 1];
                    unsorted[i + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
                break;

            swapped = false;
            end--;

            // Backward pass
            for (int i = end; i > start; i--)
            {
                if (unsorted[i] < unsorted[i - 1])
                {
                    int temp = unsorted[i];
                    unsorted[i] = unsorted[i - 1];
                    unsorted[i - 1] = temp;
                    swapped = true;
                }
            }

            start++;
        }
        array = unsorted;

        Console.WriteLine("Sorted array:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}