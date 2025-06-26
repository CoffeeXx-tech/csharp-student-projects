using System;

public class PrimeNumbers
{
    public static void Main(string[] args)
    {
        int[] primeNumbers = new int[100];
        primeNumbers[0]=1;
        primeNumbers[1]=2;
        int primeCount=2; 
        Console.Write("Enter range: ");
        int n = Int32.Parse(Console.ReadLine());
        int divisors;
        for(int i=3; i<=n; i++)
        {
            divisors=0;
            for(int j=0; j<primeCount-1; j++)
            {
                if(i%primeNumbers[j]==0)
                {
                    divisors++;
                }
            }
            if(divisors==1)
            {
                primeNumbers[primeCount]=i;
                primeCount=primeCount+1;
            }
        }
        Console.Write($"Prime numbers in range from 2 to {n}: ");
        for(int k=1; k<primeCount; k++)
        {
            Console.Write($"{primeNumbers[k]}, ");
        }
        
    }
}