using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to C# Basics!");

        // Call example methods
        ShowVariables();
        ShowOperators();
    }

    static void ShowVariables()
    {
        int age = 25;
        double price = 99.99;
        char grade = 'A';
        string name = "Alice";
        bool isStudent = true;

        Console.WriteLine($"Name: {name}, Age: {age}, Price: {price}, Grade: {grade}, Student: {isStudent}");
    }

    static void ShowOperators()
    {
        int a = 10, b = 5;

        Console.WriteLine($"Addition: {a + b}");
        Console.WriteLine($"Multiplication: {a * b}");
        Console.WriteLine($"Division: {a / b}");
        Console.WriteLine($"Modulus: {a % b}");
    }
}
