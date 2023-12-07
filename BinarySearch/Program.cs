using BinarySearchAlgorithm;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("This is a demo of a binary search algorithm:");

        List<int> sortedNumbers = new List<int>() { 1,3,5,7,9,11 };
        int numberToSearch = 9;

        var binarySearch = new BinarySearch(sortedNumbers, numberToSearch);

        var foundNumberIndex = binarySearch.Operate();

        Console.WriteLine("Found number index: " + foundNumberIndex);
        Console.ReadKey();
    }
}