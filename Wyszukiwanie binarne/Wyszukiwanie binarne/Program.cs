using System;

class BinarySearch
{
    static int BinarySearchAlgorithm(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;

            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    static void Main()
    {
        // Przykładowa posortowana tablica liczb całkowitych
        int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

        Console.Write("Podaj liczbę do znalezienia: ");
        int target = Convert.ToInt32(Console.ReadLine());

        int result = BinarySearchAlgorithm(array, target);

        if (result != -1)
            Console.WriteLine($"Liczba {target} znajduje się na indeksie {result}.");
        else
            Console.WriteLine($"Liczba {target} nie została znaleziona w tablicy.");
    }
}
