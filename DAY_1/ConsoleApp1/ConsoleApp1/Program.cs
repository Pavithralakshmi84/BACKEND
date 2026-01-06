using System;

namespace NumberCheckerAndTempConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# Programs Demo ===");
            Console.WriteLine();

            // Test Odd/Even Checker
            CheckOddEven();
            Console.WriteLine();

            // Test Temperature Converter
            TemperatureConverter();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        #region Odd Even Checker

        /// Program to check if a number is odd or even

        static void CheckOddEven()
        {
            Console.WriteLine("1. ODD/EVEN CHECKER");
            Console.WriteLine("===================");

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is a Even Number");
            }
            else
            {
                Console.WriteLine($"{number} is a Odd Number");
            }
        }
        #endregion

        #region Temperature Converter

        /// Program to convert Celsius to Fahrenheit and vice versa

        static void TemperatureConverter()
        {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            Console.WriteLine("Enter your choice (1 or 2): ");

            int choice = int.Parse(Console.ReadLine());
            int result;
            Console.WriteLine("Enter the Temperature");
            int temp = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        result = (temp * 9 / 5) + 32;

                        Console.WriteLine($"{temp}°C = {result}°F");
                        break;

                    }
                case 2:
                    {
                        result = temp + 32 * 5 / 9;
                        Console.WriteLine($"{temp}°F={result}°C");
                        break;
                    }

            }
        }
        #endregion
    }
}
