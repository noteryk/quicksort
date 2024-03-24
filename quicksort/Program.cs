using System;

class QuickSort
{
    static void Main()
    {
        int[] array = { 7, 2, 1, 6, 8, 5, 3, 4 };
        Console.WriteLine("Tablica przed sortowaniem:");
        PrintArray(array);

        QuickSortAlgorithm(array, 0, array.Length - 1);

        Console.WriteLine("Tablica po sortowaniu:");
        PrintArray(array);
    }

    static void QuickSortAlgorithm(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);
            QuickSortAlgorithm(array, left, pivotIndex - 1);
            QuickSortAlgorithm(array, pivotIndex + 1, right);
        }
    }

    static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }
        Swap(array, i + 1, right);
        return i + 1;
    }

    static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    static void PrintArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
