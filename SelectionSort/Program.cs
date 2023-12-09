using SelectionSortAlgorithms;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("This is a SelectionSort demo:");
        int[] numbers = { 3, 6, 2, 5, 4, 1, 9, 8, 7 };

        var sortedNumbers = new SelectionSort(numbers).Sort();

        Console.WriteLine("Unsorted numbers: ");
        numbers.ToList().ForEach(x => Console.WriteLine(x));

        Console.WriteLine("Sorted numbers: " );
        sortedNumbers.ToList().ForEach(x => Console.WriteLine(x));
        Console.ReadKey();
    }
}