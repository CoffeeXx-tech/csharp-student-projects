using System;

class ShoppingCart
{
    
    public static string[] productNames = {"doll","ball","puzzle","toyCar","bricks"};
    public static int[] productQuantities = {5,11,21,4,19};
    public static int[] productPrices = {7,10,14,16,5};
    public static string product; 
    
    public static int[] cart = new int[10]; 
    public static int[] quantitiesInCart= new int[10]; 
    public static int wallet=0;
    public static int choice=0; 
    public static int cartIndex=0; 
    
    public static string newProduct;
    
    public static void Main(string[] args)
    {
        ShowMenu();
        while(true)
        {
        switch(choice)
        {
            case 1:
            Purchase(); 
            break;
            
            case 2:
            AddProduct();
            ShowMenu();
            break;
            
            case 3:
            ViewCart(); 
            ShowMenu();
            break;
            
            case 4:
            Environment.Exit(0); 
            break;
            
            default:
            Console.WriteLine("Unknown command. Please try again.");
            ShowMenu();
            break;
        }
        }
    }
    
    public static void ShowMenu()
    {
        
        Console.WriteLine ("1. Buy product \n2. Add product to inventory\n3. Show total purchases (wallet)\n4. Exit");
        Console.WriteLine("What do you want to do?");
        choice=Int32.Parse(Console.ReadLine());
    }
    
    public static void Purchase() 
    {
        string answer ="yes";
        while(answer=="yes")
        {
            Console.WriteLine("Available products: ");
            for(int i=0; i<productNames.Length; i++)
            {
                Console.WriteLine($"{productNames[i]} - {productQuantities[i]} units available, price: {productPrices[i]} USD");
            }
            Console.WriteLine("Enter product name: ");
            product=Console.ReadLine();
            bool found= false; 
            for(int i=0; i<productNames.Length; i++)
        {
            if(product==productNames[i])
            {
                found=true;
                break;
            }
        }
        
            if(found==true)
            {
                for(int i=0; i<productNames.Length; i++)
                {
                    if(product==productNames[i])
                {
                    Console.WriteLine("Enter quantity: ");
                    quantitiesInCart[cartIndex] = Int32.Parse(Console.ReadLine());
                    if(productQuantities[i]>=quantitiesInCart[cartIndex])
                    {
                        productQuantities[i]=productQuantities[i]-quantitiesInCart[cartIndex];  
                        wallet=wallet+(quantitiesInCart[cartIndex]*productPrices[i]); 
                        Console.WriteLine("Added to cart successfully!");
                        cart[cartIndex]=i; 
                        cartIndex++; 
                    }
                    else
                    {
                    Console.WriteLine("Not enough quantity in inventory");
                    }
                }
            }
            }
            else
            {
                Console.WriteLine("Product is not in inventory.");
            }
        Console.WriteLine("Do you want to add another product to the cart? yes/no");
        answer = Console.ReadLine();
        if(answer=="no")
        {
            ShowMenu(); 
        }
        }
       
    }
    
     

public static void AddProduct()
{
    Console.WriteLine("Enter product name: ");
    newProduct=Console.ReadLine();
    bool exists=false;
    
    for(int i=0; i<productNames.Length; i++)
        {
            if(newProduct==productNames[i])
            {
                exists=true;
            }
        }
    if(exists==false)
    {

    Array.Resize(ref productNames, productNames.Length + 1);
    productNames[productNames.Length - 1]=newProduct;
    
    Console.WriteLine("Enter quantity: ");
    Array.Resize(ref productQuantities, productQuantities.Length + 1);
    productQuantities[productQuantities.Length - 1] =Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Enter price (per unit): ");
    Array.Resize(ref productPrices, productPrices.Length + 1);
    productPrices[productPrices.Length - 1] =Int32.Parse(Console.ReadLine());
    
     Console.WriteLine($"Successfully added {newProduct} to inventory!\n");
    }
    else
    {
        for(int i=0; i<productNames.Length; i++)
                {
                    if(newProduct==productNames[i])
                    {
                        int total=0;
                        Console.WriteLine("Product already in inventory. How many do you want to add?");
                        total = Int32.Parse(Console.ReadLine()); 
                        productQuantities[i]=productQuantities[i]+total; 
                        Console.WriteLine($"Successfully added {total} units of {newProduct} to inventory!\n");
                        ShowMenu();
                    }
                }
    }
}


public static void ViewCart() 
    {
        int n;
        int suma;
        if(cartIndex==0) 
        {
            Console.WriteLine("Your cart is empty");
        }
        else
        {
        Console.WriteLine("Your cart:\n");
        for(int i=0; i<cartIndex; i++)
        {
            n = cart[i]; 
            suma=quantitiesInCart[i]*productPrices[n]; 
            Console.WriteLine($"Product: {productNames[n]} quantity:{quantitiesInCart[i]} total: {suma} USD");
        }
        Console.WriteLine($"Total sum: {wallet} USD\n");
    }
    }

}