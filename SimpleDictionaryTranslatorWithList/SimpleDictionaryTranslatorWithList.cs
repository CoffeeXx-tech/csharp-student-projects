using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Dictionary Translator\nEnter words to translate from English to Polish.");
        Dictionary<string, string> dictionary = new Dictionary<string, string>
        {
            { "dog", "pies" },
            { "cat", "kot" },
            { "hello", "witaj" }
        };
    Console.WriteLine("\nTranslation:");
    string wordToTranslate = Console.ReadLine();
        
            if(dictionary.ContainsKey(wordToTranslate))
            {
                Console.WriteLine($"{dictionary[wordToTranslate]}");
            }
            else
                 Console.WriteLine($"Not found in dictionary: {wordToTranslate}");
    }
}