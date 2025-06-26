using System;
class Rectangle
{
  static void Main() 
  {
    Console.Write("Height: ");
    int height = 1;
    height=Int32.Parse(Console.ReadLine());
    Console.Write("Width: ");
    int width=Int32.Parse(Console.ReadLine());
    for(int i=0; i<height; i++)
    {
        Console.Write("*");
        for(int j=1; j<width; j++)
        {
            Console.Write("*");
        }
        Console.Write("\n");
    }
  }
}