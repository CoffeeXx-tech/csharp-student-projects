using System;
using System.Collections.Generic;
class ShoppingListManagerWithList
{
  static int Main() 
  {
      int itemCount=0;
      int counter=0;
    List<string> shoppingList = new List<string>{};
    Console.WriteLine("Shopping List\n1. Add item\n2. View list\n3. Remove item");
    int response=Int32.Parse(Console.ReadLine());
    while(true)
    {
    switch(response)
    {
        case 1:
        Console.WriteLine("Add an item to the shopping list: ");
        string addItem=Console.ReadLine();
        shoppingList.Add(addItem);
        itemCount++;
        Console.WriteLine("Shopping List\n1. Add item\n2. View list\n3. Remove item");
        response=Int32.Parse(Console.ReadLine());
        break;
        case 2:
        if(itemCount==0)
        {
            Console.WriteLine("The shopping list is empty.");
            Console.WriteLine("Shopping List\n1. Add item\n2. View list\n3. Remove item");
        response=Int32.Parse(Console.ReadLine());
        }
        else
        {
        foreach (var pozycja in shoppingList)
            {
                counter++;
                Console.WriteLine($"{counter}. {pozycja}");
                Console.WriteLine("Shopping List\n1. Add item\n2. View list\n3. Remove item");
        response=Int32.Parse(Console.ReadLine());
            }       
        }
        break;
        case 3:
        string toRemove="";
        Console.WriteLine("Enter the item to remove:");
        string removeItem = Console.ReadLine();
        for (int i = 0; i < itemCount; i++)
        {
            if (shoppingList[i].Contains(removeItem))
            {
                toRemove=shoppingList[i];
            }
        }
        shoppingList.Remove(toRemove);
        Console.WriteLine("Shopping List\n1. Add item\n2. View list\n3. Remove item");
        response=Int32.Parse(Console.ReadLine());
        break;
        default:
        return 1;
        break;
    }
  }
      
  }
}