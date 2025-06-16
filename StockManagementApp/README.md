# 🛒 ShoppingCart – Simple Inventory and Cart System in C#

This is a basic console application written in C# that simulates a simple shopping cart and inventory system.

## 🧾 Features

- Predefined list of products (name, price, quantity)
- Purchase products and add them to a cart
- Automatically update stock after each purchase
- Add new products to the inventory
- View current cart contents and total cost in USD
- Basic menu navigation with user input

## 📋 How It Works

1. The user is shown a menu with options:
   - Buy product
   - Add product to inventory
   - Show total purchases (wallet)
   - Exit

2. During a purchase:
   - The user selects a product by name and enters the quantity.
   - If the product exists and there’s enough quantity, it’s added to the cart.
   - The total amount (in USD) is calculated and stored in the wallet.

3. New products can be added with quantity and price.
4. The cart can be viewed at any time, showing items and total cost.

## 🛠️ Technologies

- C# (.NET Console App)
- Basic arrays and loops
- User input handling via `Console.ReadLine()`

## 💡 Example Interaction

    Buy product

    Add product to inventory

    Show total purchases (wallet)

    Exit
    What do you want to do? 1

Available products:
doll - 5 units available, price: 7 USD
ball - 11 units available, price: 10 USD
...

Enter product name: ball
Enter quantity: 2
Added to cart successfully!
Do you want to add another product to the cart? no

Your cart:
Product: ball quantity:2 total: 20 USD
Total sum: 20 USD

---

Feel free to clone this repo and test the program in your favorite C# development environment.