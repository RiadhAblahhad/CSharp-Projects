using System;

namespace MathOperationApp
{
    // This class performs basic arithmetic operations
    class Calculator
    {
        // Method that takes two integers and adds 10 to the first, then displays the second
        public void ProcessNumbers(int number1, int number2)
        {
            int result = number1 + 10; // Add 10 to the first number
            Console.WriteLine("First number + 10 = " + result); // Display result of math operation
            Console.WriteLine("Second number is: " + number2); // Display the second number
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Calculator class
            Calculator calc = new Calculator();

            // Call method using positional parameters
            calc.ProcessNumbers(3, 23);

            // Call method using named parameters
            calc.ProcessNumbers(number2: 30, number1: 7);
        }
    }
}
