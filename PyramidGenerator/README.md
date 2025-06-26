# 🧱 PyramidGenerator – Print a Text-Based Pyramid in C#

This is a simple console application written in C# that generates a left-aligned pyramid made of asterisks (`*`) based on the user-specified height.

## 🧾 Features

- Prompts the user to enter the height of the pyramid
- Uses nested `for` loops to build each row of the pyramid
- Outputs a pyramid made of asterisks, aligned to the left

## 📋 How It Works

1. The user is prompted to input a number representing the pyramid's height.
2. The outer loop (`i`) iterates from 0 to `height - 1`, representing each row.
3. The inner loop (`j`) prints additional asterisks to match the current row index.
4. Each row prints `i + 1` asterisks, forming a growing left-aligned triangle.

## 🛠️ Technologies

- C# (.NET Console App)
- Console input/output
- Nested `for` loops
- Basic string formatting

## 💡 Example Output

Enter the height of the pyramid:
5
*
**
***
****
*****


---

You can clone this project and run it in your preferred C# development environment (like Visual Studio or VS Code).
