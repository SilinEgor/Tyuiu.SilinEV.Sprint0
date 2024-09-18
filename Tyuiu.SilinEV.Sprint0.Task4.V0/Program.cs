using Tyuiu.SilinEV.Sprint0.Task4.V0.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(DataService.Additional(1, 5));
        Console.WriteLine(DataService.Subtraction(15, 5));
        Console.WriteLine(DataService.Multiplication(10, 10));
        Console.WriteLine(DataService.Division(5, 5));
        Console.ReadKey();
    }
}