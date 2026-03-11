1. Write a C# program that reads a list of integers from the user and throws an exception if any numbers are duplicates.**
2. using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.Write("How many numbers do you want to enter? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            // check duplicate
            for (int j = 0; j < numbers.Count; j++)
            {
                if (numbers[j] == num)
                {
                    throw new Exception("Duplicate number detected!");
                }
            }

            numbers.Add(num);
        }
2. Write a C# program to create a method that takes a string as input and throws an exception if the string does not contain vowels.
using System;

class Program
{
    static void CheckVowels(string text)
    {
        bool hasVowel = false;

        for (int i = 0; i < text.Length; i++)
        {
            char c = char.Parse(text[i]);

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                hasVowel = true;
            }
        }

        if (!hasVowel)
        {
            throw new Exception("String does not contain vowels!");
        }
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        CheckVowels(input);

        Console.WriteLine("String contains vowels.");
    }
}
        Console.WriteLine("All numbers are unique.");
    }
}
