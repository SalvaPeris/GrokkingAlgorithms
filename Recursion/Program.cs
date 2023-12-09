using Recursion;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("This is a recursion class demo for get the factorial of a number: ");
        var number = 5;
        var factorial = RecursionMethods.Factorial(number);

        Console.WriteLine($"Factorial of number {number}: " + factorial);
        Console.ReadKey();
    }
}