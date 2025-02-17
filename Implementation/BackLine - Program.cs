using System;

namespace RecursiveDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 0;

            // Get and validate the first number
            number1 = GetValidatedInput("Enter the first number: ");

            // Get and validate the second number
            number2 = GetValidatedInput("Enter the second number: ");

            // Sum the two numbers
            int initialSum = number1 + number2;
            Console.WriteLine($"\nInitial sum: {number1} + {number2} = {initialSum}\n");

            try
            {
                // Process the sum recursively
                int finalResult = RecursiveDigitAddition(initialSum);
                Console.WriteLine($"\nFinal single digit result: {finalResult}");
            }
            catch (Exception ex)
            {
                // Catch any unexpected errors during processing
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        /// <summary>
        /// Prompts the user for input and validates that it is a valid integer.
        /// </summary>
        /// <param name="prompt">The prompt message to display.</param>
        /// <returns>A valid integer entered by the user.</returns>
        static int GetValidatedInput(string prompt)
        {
            int number;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }

        /// <summary>
        /// Recursively reduces a number by adding its last digit to the rest of the number,
        /// continuing until a single digit is obtained.
        /// </summary>
        /// <param name="number">The number to reduce.</param>
        /// <returns>A single digit integer.</returns>
        static int RecursiveDigitAddition(int number)
        {
            // Base case: if the number is a single digit, return it
            if (number < 10 && number > -10)
            {
                return number;
            }

            // Separate the least significant digit and the remaining digits
            int lastDigit = number % 10;
            int remainingDigits = number / 10;
            int newSum = remainingDigits + lastDigit;

            // Display the current step
            Console.WriteLine($"{remainingDigits} + {lastDigit} = {newSum}");

            // Recurse with the new sum
            return RecursiveDigitAddition(newSum);
        }
    }
}