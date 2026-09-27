using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("how many numbers");
        int n = Convert.ToInt32(Console.ReadLine());
        List<int> numbers = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Please write number" + i + ":");
            /* string input = Console.ReadLine();
             numbers.Add(Convert.ToInt32(input));*/
            numbers.Add(Convert.ToInt32(Console.ReadLine()));
        }
        numbers.Reverse();
        foreach (int s in numbers)
        {
            Console.Write(s + ",");
        }
    }
}
