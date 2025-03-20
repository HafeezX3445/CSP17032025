using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using VariablesExample.Concepts;

class Sample
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nSelect a Concept to Learn:");
            Console.WriteLine("1. Variables");
            Console.WriteLine("2. Data Types");
            Console.WriteLine("N. Exit");

            Console.Write("Enter your choice (1-N): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayVariables();
                    break;
                case "N":
                    Console.WriteLine("Exiting... Have a great day!");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please select a valid option.");
                    break;
            }
        }

        Console.ReadLine();
    }

    public static void DisplayVariables()
    {
        Variables varObj = new Variables();
        Console.WriteLine("\n--- 1. Variables ---");

        Console.WriteLine(varObj.GetDefinition()); // check
        foreach (var item in varObj.TypesOfVariables())
        {
            Console.WriteLine(item);
        }
    }

}