# 🛒 ShoppingListManagerWithList – Manage a Simple Shopping List in C#

This console application allows users to manage a basic shopping list using a text interface. The program supports adding, viewing, and removing items from the list using a menu system.

## 🧾 Features

- Add items to a shopping list
- View the current list with numbered entries
- Remove items from the list by name
- Uses a `List<string>` for dynamic item storage

## 📋 How It Works

1. The program displays a menu with three options: add item, view list, remove item.
2. When **Add item** is selected, the user inputs an item, which is added to the list.
3. When **View list** is selected:
   - If the list is empty, the user is notified.
   - If not, each item is displayed with its number.
4. When **Remove item** is selected, the user inputs the name (or part of it) of the item to remove.
   - The first matching item is removed from the list.
5. The program loops continuously, allowing multiple operations until an invalid choice ends it.

## 🛠️ Technologies

- C# (.NET Console App)
- `List<string>` for storing dynamic data
- `switch` statements for menu handling
- `Console.ReadLine()` and `Console.WriteLine()` for user interaction

## 💡 Example Usage

Shopping List

    Add item

    View list

    Remove item

    1
    Add an item to the shopping list:
    Milk

Shopping List

    Add item

    View list

    Remove item

    2

    Milk

Shopping List

    Add item

    View list

    Remove item

    3
    Enter the item to remove:
    Milk


## 🔧 Improvements You Could Add

- Case-insensitive search for item removal
- Confirmation prompt before removing an item
- Exit option in the menu
- Save/load list from a file

---

Feel free to fork, clone, and modify the program in your favorite C# development environment like Visual Studio or Visual Studio Code.
