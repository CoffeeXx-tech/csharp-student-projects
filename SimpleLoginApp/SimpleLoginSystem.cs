using System;
using System.Linq;

public class login
{
    public static void Main(string[] args)
    {
        bool isValid = false;
        int attemptCount=0;
        while(attemptCount<3)
        {
        Console.WriteLine("Enter username: ");
        string username = Console.ReadLine ();
        int usernameLength = username.Length;
        Console.WriteLine("Enter password: ");
        string password = Console.ReadLine ();
        int passwordLength = password.Length;
        if(usernameLength>=5)
        {
                if(passwordLength>=8)
                {
                    isValid = password.Any(char.IsDigit);
                    if(isValid==true)
                    {
                        Console.WriteLine("Login completed successfully.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Password must contain at least one digit.");
                        attemptCount++;
                    }
                }
                else
                {
                    Console.WriteLine("Password must be at least 8 characters long.");
                    attemptCount++;
                }
        }
        else
        {
            Console.WriteLine("Username must be at least 5 characters long");
            attemptCount++;
        }}}
    }