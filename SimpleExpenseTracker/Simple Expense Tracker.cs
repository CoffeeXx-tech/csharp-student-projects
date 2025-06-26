using System;
using System.Text; 
using System.Collections.Generic; 
public class SimpleExpenseTracker
{
    public static int expensesCount = 0; 

    public static int Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; 
        List<(string name, int amount)> expenses = new List<(string, int)>();
        ShowMenu();
        int answer;
        while (!Int32.TryParse(Console.ReadLine(), out answer)) 
        {
            Console.WriteLine("Choose an option!");
        }
        while(true)
        {
            switch(answer)
            {
            case 1:
                AddExpense(expenses); 
                ShowMenu();
                while (!Int32.TryParse(Console.ReadLine(), out answer))
                    {
                        Console.WriteLine("Choose an option!");
                    }
            break;
            case 2:
                ShowExpenses(expenses);
                ShowMenu();
                while (!Int32.TryParse(Console.ReadLine(), out answer))
                    {
                        Console.WriteLine("Choose an option!");
                    }
            break;
            case 3:
                TotalAmount(expenses);
                ShowMenu();
                while (!Int32.TryParse(Console.ReadLine(), out answer))
                    {
                        Console.WriteLine("Choose an option!");
                    }
                break;
            case 4:
                HighestExpense(expenses);
                ShowMenu();
                while (!Int32.TryParse(Console.ReadLine(), out answer))
                    {
                        Console.WriteLine("Choose an option!");
                    }
                break;
            case 5:
                RemoveExpense(expenses);
                ShowMenu();
                while (!Int32.TryParse(Console.ReadLine(), out answer))
                    {
                        Console.WriteLine("Choose an option!");
                    }
                break;
            case 6:
                Environment.Exit(0); 
                break;
            default:
                Console.WriteLine("Unknown command");
                ShowMenu();
                while (!Int32.TryParse(Console.ReadLine(), out answer))
                    {
                        Console.WriteLine("Choose an option!");
                    }
                break;
            }
        }
    }
    public static void ShowMenu()
    {
        Console.WriteLine ("1. Add expense\n2. Show expenses list\n3. Calculate total expenses\n4. Show highest expense\n5. Remove expense\n6. Exit\nChoose an option: "); //menu
    }
    public static void AddExpense(List<(string name, int amount)> expenses)
    {
        Console.WriteLine("Add expense:");
        string expense="";
                while (string.IsNullOrEmpty(expense))
                {
                    Console.Write("Enter name: ");
                    expense = Console.ReadLine();  
                    if (string.IsNullOrEmpty(expense))
                    {
                        Console.WriteLine("Name cannot be empty. Try again.");
                    }
                }
                expense  = char.ToUpper(expense[0]) + expense.Substring(1).ToLower(); 
                int amount;
                while(true)
                {
                    Console.Write("amount: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out amount) && amount > 0)
                    {
                        expenses.Add((expense, amount));
                        expensesCount++;
                        break;
                    }
                    Console.Write("Enter a valid amount (greater than 0): ");                 }
    }
    public static void ShowExpenses(List<(string name, int amount)> expenses)
    {
        if(expensesCount==0)
                {
                  Console.WriteLine("No expenses on the list..");  
                }
                else
                {
                    for(int i=0; i<expensesCount; i++)
                    {
                    Console.WriteLine($"{i+1}. {expenses[i].name} - {expenses[i].amount} USD"); 
                    }
                }
    }
    public static void TotalAmount(List<(string name, int amount)> expenses)
    {
        int sum=0;
        if(expensesCount==0)
                {
                  Console.WriteLine("Brak wydatków na liście.");  
                }
                else
                {
                    for(int i=0; i<expensesCount; i++)
                    {
                    sum=expenses[i].amount+sum; 
                    }
                    Console.WriteLine($"Total expenses amount: {sum} USD");
                }
    }
    public static void HighestExpense(List<(string name, int amount)> expenses)
    {
        int highestAmoun=0, index=-1;
        if(expensesCount==0)
                {
                  Console.WriteLine("Brak wydatków na liście.");  
                }
                else
                {
                    for(int i=0; i<expensesCount; i++) 
                    {
                    if(highestAmoun<expenses[i].amount) 
                    {
                        highestAmoun=expenses[i].amount;
                        index=i;
                    }
                    }
                    Console.WriteLine($"Highest expense: {expenses[index].name} - {highestAmount} USD");  
                }
    }
    public static void RemoveExpense(List<(string name, int amount)> expenses)
    {
        if(expensesCount==0)
                {
                  Console.WriteLine("No expenses on the list.");  
                }
        else
           {
            
                for(int i=0; i<expensesCount; i++)
                {
                 Console.WriteLine($"{i+1}. {expenses[i].name} - {expenses[i].amount} USD"); 
                 }
           
           int removeIndex;
           Console.Write("Choose the number of the expense you want to remove: ");
             while (((!Int32.TryParse(Console.ReadLine(), out removeIndex))&&removeIndex>0)&&removeIndex<=expensesCount) 
        {
            Console.WriteLine("Enter a valid number!");
        }
        removeIndex--; 
        int confirm;
        Console.WriteLine($"Are you sure you want to remove item  {removeIndex+1}. {expenses[removeIndex].name} - {expenses[removeIndex].amount} USD? yes-1, no-2");

while (true)
{ 
    if (!Int32.TryParse(Console.ReadLine(), out confirm)) 
    {
        Console.WriteLine("Invalid input. Please type again: Yes - 1, No - 2");
        continue; 
    }
    if (confirm == 1)
    {
        expenses.RemoveAt(removeIndex);
        expensesCount--;
        Console.WriteLine("Expense successfully removed!");
        break; 
    }
    else if (confirm == 2)
    {
        Console.WriteLine("Operation canceled.");
        break;
    }
    else
    {
        Console.WriteLine("Invalid choice. Enter: Yes - 1 or No - 2");
    }
}}}}