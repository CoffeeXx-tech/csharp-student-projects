using System;

public class Counting
{
    public static void Main(string[] args)
    {
        int[] array = new int[100];
        int sum=0;
        Console.WriteLine ("Enter the number of elements:");
        int n = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the numbers:");
        for(int i=0; i<n; i++)
        {
            array[i]=Int32.Parse(Console.ReadLine());
            sum=sum+array[i];
        }
        Console.WriteLine($"The total sum of elements is: {sum}");
    }
}