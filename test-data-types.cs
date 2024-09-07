using System;

class Calculator
{
    static void Main(string[] args)
    {
        // Taking user input for numbers and operator
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the operator (+, -, *, /):");
        char op = Console.ReadKey().KeyChar;

        Console.WriteLine("\nEnter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Using switch to perform the calculation based on the operator
        switch (op)
        {
            case '+':
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;

            case '-':
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;

            case '*':
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;

            case '/':
                // Check to avoid division by zero
                if (num2 != 0)
                {
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Error! Division by zero.");
                }
                break;

            default:
                Console.WriteLine("Invalid operator! Please enter one of (+, -, *, /).");
                break;
        }
    }
}
