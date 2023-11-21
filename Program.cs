using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");

        while (true)
        {
            Console.WriteLine("\n1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PerformOperation(Addition);
                    break;
                case "2":
                    PerformOperation(Subtraction);
                    break;
                case "3":
                    PerformOperation(Multiplication);
                    break;
                case "4":
                    PerformOperation(Division);
                    break;
                case "5":
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }

    static void PerformOperation(Func<double, double, double> operation)
    {
        Console.Write("Enter the first number: ");
        if (double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.Write("Enter the second number: ");
            if (double.TryParse(Console.ReadLine(), out double num2))
            {
                double result = operation(num1, num2);
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input for the second number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for the first number.");
        }
    }

    static double Addition(double num1, double num2) => num1 + num2;
    static double Subtraction(double num1, double num2) => num1 - num2;
    static double Multiplication(double num1, double num2) => num1 * num2;
    static double Division(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero is undefined.");
            return 0;
        }
        else
        {
            return num1 / num2;
        }
    }
}
