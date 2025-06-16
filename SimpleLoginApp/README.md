# 🔐 SimpleLogin – Basic Login System in C#

This is a simple console application written in C# that simulates a basic login system with input validation.

## 🧾 Features

- Prompts the user to enter a username and password
- Validates that:
  - Username is at least 5 characters long
  - Password is at least 8 characters long and contains at least one digit
- Displays error messages for invalid input
- Allows up to 3 login attempts
- On successful login, displays a success message

## 📋 How It Works

1. The user is asked to enter a username and password.
2. The input is validated using:
   - `.Length` for character count
   - `.Any(char.IsDigit)` to check for digits in the password
3. If the input is invalid:
   - A specific error message is shown
   - The user has up to 3 chances to try again
4. If the input is valid:
   - A success message is displayed:  
     **"Login completed successfully."**

## 🛠️ Technologies

- C# (.NET Console App)
- String handling and input validation
- Basic loops and conditional logic
- Console-based interaction via `Console.ReadLine()`

## 💡 Example Interaction

    Enter username: user123
    Enter password: password1
    Login completed successfully.

If the username is too short or the password is invalid, an error message is displayed and the user is prompted again (up to 3 times).

---

Feel free to clone this repo and test the program in your favorite C# development environment.
