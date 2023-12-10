using QuickSortAlgorithm;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("This is a quick sort algorithm demo :");

        int[] numbers = new int[] { 5, 1, 4, 6, 3, 9, 7, 2, 8 };

        var result = Sort.QuickSort(numbers);

        Console.WriteLine("Unsorted array: ");
        numbers.ToList().ForEach(x => Console.WriteLine(x));

        Console.WriteLine("Sorted array: ");
        result.ToList().ForEach(x => Console.WriteLine(x));
        Console.ReadKey();
    }
}