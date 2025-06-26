using System;

public class Factorial
{
    public static void Main(string[] args)
    {
        int result=1;
        Console.WriteLine ("Calculate factorial for number: ");
        int n = Int32.Parse(Console.ReadLine());
        for(int i=1; i<=n; i++)
        {
            result*=i;
        }
        Console.WriteLine ($"Result: {result}");
    }
}