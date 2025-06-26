using System;

public class EvenOddNumbers
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[51];
        for(int i=0; i<50; i++)
        {
            numbers[i]=i+1;
        }
        Console.WriteLine ("Even numbers: ");
        for(int i=1; i<50; i++)
        {
            if(numbers[i]%2==0)
            {
                Console.Write($"{numbers[i]}, ");
            }
        }
        Console.WriteLine ("\nOdd numbers:");
        for(int i=1; i<50; i++)
        {
            if(numbers[i]%2!=0)
            {
                Console.Write($"{numbers[i]}, ");
            }
        }
    }
}