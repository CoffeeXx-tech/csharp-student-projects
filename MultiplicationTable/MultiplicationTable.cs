using System;

public class MultiplicationTable
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Multiplication Table from 1 to 10:");
        for(int i=1; i<=10; i++)
        {
        Console.Write($"{i} "); 
            for(int j=2; j<=10; j++)
            {
                Console.Write($"{i*j} "); 
            }
            Console.Write("\n"); 
        }
    }
}