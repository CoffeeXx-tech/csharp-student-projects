# 🎯 NumberGuessingGame – Number Guessing Game in C#

This is a simple console-based number guessing game written in C#. The user tries to guess a randomly generated number between 1 and 100.

## 🧾 Features

- Randomly selects a number from 1 to 100
- Prompts the user to guess the number
- Provides feedback: "higher" or "lower" after each guess
- Ends when the correct number is guessed

## 📋 How It Works

1. The program generates a random number using `Random.Next(1, 101)`.
2. The user is prompted to enter their first guess.
3. A `while` loop runs until the user guesses the correct number.
4. After each guess:
   - The program tells the user whether the target number is higher or lower.
5. When the user guesses the correct number, a congratulatory message is displayed.

## 🛠️ Technologies

- C# (.NET Console App)
- Random number generation with `Random`
- Input handling with `Console.ReadLine()` and `Int32.Parse()`
- Conditional logic with `if` statements and a `while` loop

## 💡 Example Interaction

Guess the number (between 1 and 100):

    50
    The target number is higher.
    75
    The target number is lower.
    63
    The target number is higher.
    68
    Congratulations! You guessed the number: 68

---

Feel free to clone the repository and run the code in your preferred C# development environment (e.g. Visual Studio or VS Code).
