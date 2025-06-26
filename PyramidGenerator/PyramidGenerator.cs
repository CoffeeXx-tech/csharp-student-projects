using System;

public class PyramidGenerator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the height of the pyramid:");
        int height = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < height; i++)
        {
            Console.Write("*");
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}