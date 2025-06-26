# 🔢 PrimeNumbers – Find Prime Numbers up to a Given Range in C#

This is a simple console application written in C# that finds and displays all prime numbers from 2 up to a user-specified range.

## 🧾 Features

- Prompts the user to enter the upper limit (`n`)
- Uses an array to store found prime numbers
- Efficiently checks divisibility only with previously found primes
- Outputs the list of prime numbers between 2 and `n`

## 📋 How It Works

1. The user is prompted to input a number `n`.
2. The program starts with a predefined array to store prime numbers and seeds it with 1 and 2 (although 1 is not prime—see note).
3. For each number `i` from 3 to `n`, it checks if `i` is divisible by any known primes.
4. If `i` is only divisible by one known prime (excluding 1), it is added to the list.
5. At the end, all primes from 2 to `n` are printed.

⚠️ **Note**: This program includes `1` in the array for initialization, but mathematically `1` is *not* considered a prime number. The actual list starts printing from the index containing `2`.

## 🛠️ Technologies

- C# (.NET Console App)
- Integer arrays
- Nested `for` loops
- Console input/output

## 💡 Example Interaction

Enter range: 20
Prime numbers in range from 2 to 20: 2, 3, 5, 7, 11, 13, 17, 19,


---

Feel free to fork this repo and test the code in your favorite IDE like Visual Studio or Visual Studio Code.
