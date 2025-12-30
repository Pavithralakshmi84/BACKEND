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
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                string result = (number % 2 == 0) ? "EVEN" : "ODD";
                Console.WriteLine($"\n{number} is {result}!");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }
        #endregion

        #region Temperature Converter
     
        /// Program to convert Celsius to Fahrenheit and vice versa
       
        static void TemperatureConverter()
        {
            Console.WriteLine("2. TEMPERATURE CONVERTER");
            Console.WriteLine("========================");

            Console.WriteLine("Choose conversion:");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            Console.Write("Enter choice (1 or 2): ");

            if (int.TryParse(Console.ReadLine(), out int choice) && (choice == 1 || choice == 2))
            {
                Console.Write("Enter temperature value: ");
                if (double.TryParse(Console.ReadLine(), out double temp))
                {
                    double result = 0;
                    string fromUnit, toUnit;

                    if (choice == 1)
                    {
                        result = (temp * 9 / 5) + 32;
                        fromUnit = "°C"; toUnit = "°F";
                    }
                    else
                    {
                        result = (temp - 32) * 5 / 9;
                        fromUnit = "°F"; toUnit = "°C";
                    }

                    Console.WriteLine($"\n{temp}{fromUnit} = {result:F2}{toUnit}");
                }
                else
                {
                    Console.WriteLine("Invalid temperature value!");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice! Please enter 1 or 2.");
            }
        }
        #endregion
    }
}
