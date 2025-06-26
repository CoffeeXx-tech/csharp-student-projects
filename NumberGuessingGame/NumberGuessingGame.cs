using System;

public class NumberGuessingGame
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int targetNumber = random.Next(1, 101);
        Console.WriteLine("Guess the number (between 1 and 100): ");
        int userGuess =Int32.Parse(Console.ReadLine());
        while(userGuess!=targetNumber)
        {
            if(targetNumber>userGuess)
            {
                Console.WriteLine("The target number is higher.");
            }
            else if(targetNumber<userGuess)
            {
                Console.WriteLine("The target number is lower.");
            }
            userGuess =Int32.Parse(Console.ReadLine());
        }
        if(userGuess==targetNumber)
        {
            Console.Write($"Congratulations! You guessed the number: {targetNumber}");
        }
    }
} 