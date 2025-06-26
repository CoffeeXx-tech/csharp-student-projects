using System;

public class FibonacciSequence
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Fibonacci sequence of n elements: ");
        int count=Int32.Parse(Console.ReadLine());
        int previous=0;
        int previousPrevious=1;
        int suma=0;
        Console.Write("0, ");
        while(count!=0)
        {
            suma=previousPrevious+previous;
            Console.Write($"{suma}, ");
            previousPrevious=previous;
            previous=suma;
            count--;
        }
    }
}