using System;
using BasicMathLibrary;

/*Zeynep Ozdemir
 * Lab 7 OOP 
 */

/* Creates a program class to run the operations */
class Program
{
    static void Main()
    {
        BasicMath math = new BasicMath();

        Console.WriteLine("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose an operation: +, -, *, /");
        char operation = Console.ReadLine()[0];

        double result = 0;

        if (operation == '+') result = math.Add(num1, num2);
        else if (operation == '-') result = math.Subtract(num1, num2);
        else if (operation == '*') result = math.Multiply(num1, num2);
        else if (operation == '/')
        { }

        Console.WriteLine($"Result: {result}");
    }
}
