using System;
using System.Collections.Generic;

public class EvenNumberFilterWithList
{
    public static void Main(string[] args)
    {
        int check=0;
        List<int> numbers = new List<int>{};
        List<int> evenNumbers = new List<int>{};
        Console.WriteLine ("Enter 5 integers: ");
        for(int i=0; i<5; i++)
        {
            int number = Int32.Parse(Console.ReadLine());
            numbers.Add(number);
            if(numbers[i]%2==0)
            {
                evenNumbers.Add(numbers[i]);
            }
        }
        Console.WriteLine("Even numbers:");
        foreach (var even in evenNumbers)
        {
            Console.WriteLine($"{even}");
        }
    }
}