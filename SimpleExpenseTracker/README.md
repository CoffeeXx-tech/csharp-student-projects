# 💰 SimpleExpenseTracker – Console Expense Management in C#

This is a simple C# console application that helps users manage personal expenses. It allows you to add, list, remove, and calculate statistics for a set of expenses stored in memory.

## 🧾 Features

- Add a new expense with name and amount
- View all expenses in a numbered list
- Show the **total** amount spent
- Identify the **highest** single expense
- Remove an expense by choosing from the list
- Friendly console interface with basic input validation

## 📋 How It Works

1. The user is presented with a menu of available options.
2. Based on the selected option, the program:
   - Prompts for details to add an expense
   - Displays the list of existing expenses
   - Sums up and displays total expenses
   - Finds and shows the expense with the highest value
   - Allows the user to delete a specific entry
3. Input validation ensures meaningful and correct data entries.

## 🛠️ Technologies

- C# (.NET Console Application)
- `List<(string name, int amount)>` for expense tracking
- String formatting and input handling via `Console.ReadLine()`
- Unicode support with `Console.OutputEncoding`

## 💡 Example Output

Add expense

Show expenses list

Calculate total expenses

Show highest expense

Remove expense

Exit
Choose an option:

### Sample:

Enter name: Rent
amount: 1200

    Rent - 1200 USD
    Total expenses amount: 1200 USD
    Highest expense: Rent - 1200 USD

---

Feel free to expand the SimpleExpenseTracker and customize the functionality!