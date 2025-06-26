# 📘 Simple Dictionary Translator – English to Polish Translator in C#

This is a basic C# console application that allows the user to translate simple English words into Polish using a predefined dictionary.

## 🧾 Features

- Translates a limited set of English words into Polish
- Uses a `Dictionary<string, string>` for quick lookups
- Displays an appropriate message when a word is not found

## 📋 How It Works

1. The program initializes a small dictionary with English-Polish word pairs.
2. The user is prompted to input an English word.
3. The application checks if the word exists in the dictionary:
   - If it does, it displays the Polish translation.
   - If not, it informs the user that the word is not found.

## 🛠️ Technologies

- C# (.NET Console App)
- `Dictionary<string, string>` for storing translations
- Console input/output using `Console.ReadLine()` and `Console.WriteLine()`

## 💡 Example Output

Simple Dictionary Translator
Enter words to translate from English to Polish.

Translation:
dog
pies


Or:

Translation:
computer
Not found in dictionary: computer

---

Feel free to expand the dictionary and customize the functionality!