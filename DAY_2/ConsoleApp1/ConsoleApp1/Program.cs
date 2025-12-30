using System;
namespace Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program 1: Find Largest of 3 Numbers
            #region Largest of 3 Numbers
            Console.WriteLine("=== 1. Largest of 3 Numbers ===");
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());

            int largest = num1;
            if (num2 > largest) largest = num2;
            if (num3 > largest) largest = num3;

            Console.WriteLine($"Largest number is: {largest}");
            Console.WriteLine();
            #endregion

            // Program 2: Student Grade using Multiple else-if
            #region Student Grade Multiple else-if
            Console.WriteLine("=== 2. Student Grade (Multiple else-if) ===");
            Console.Write("Enter student marks (0-100): ");
            int mark1 = int.Parse(Console.ReadLine());

            string grade1;
            if (mark1 >= 90)
                grade1 = "A+";
            else if (mark1 >= 80)
                grade1 = "A";
            else if (mark1 >= 70)
                grade1 = "B";
            else if (mark1 >= 60)
                grade1 = "C";
            else if (mark1 >= 50)
                grade1 = "D";
            else if (mark1 >= 35)
                grade1 = "E";
            else
                grade1 = "F";

            Console.WriteLine($"Grade: {grade1}");
            Console.WriteLine();
            #endregion

            // Program 3: Student Grade using Switch
            #region Student Grade Switch Case
            Console.WriteLine("=== 3. Student Grade (Switch Case) ===");
            Console.Write("Enter student marks (0-100): ");
            int mark2 = int.Parse(Console.ReadLine());

            int gradeRange = mark2 / 10;
            string grade2;

            switch (gradeRange)
            {
                case 10:
                case 9:
                    grade2 = "A+";
                    break;
                case 8:
                    grade2 = "A";
                    break;
                case 7:
                    grade2 = "B";
                    break;
                case 6:
                    grade2 = "C";
                    break;
                case 5:
                    grade2 = "D";
                    break;
                case 4:
                case 3:
                    grade2 = "E";
                    break;
                default:
                    grade2 = "F";
                    break;
            }

            Console.WriteLine($"Grade: {grade2}");
            Console.WriteLine();
            #endregion

            // Program 4: Employment Eligibility using Ternary
            #region Employment Eligibility Ternary
            Console.WriteLine("=== 4. Employment Eligibility (Ternary) ===");
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            string eligible = (age >= 18) ? "Eligible for employment" : "Not eligible for employment";
            Console.WriteLine(eligible);
            Console.WriteLine();
            #endregion

            // Program 5: ARITHMETIC OPERATORS
            #region 
            Console.WriteLine("=== 5. All Operators Demo ===");
            Console.Write("Enter first value: ");
            int val1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second value: ");
            int val2 = int.Parse(Console.ReadLine());

 
            Console.WriteLine("\n--- Arithmetic Results ---");
            Console.WriteLine($"Addition (+): {val1} + {val2} = {val1 + val2}");
            Console.WriteLine($"Subtraction (-): {val1} - {val2} = {val1 - val2}");
            Console.WriteLine($"Multiplication (*): {val1} * {val2} = {val1 * val2}");
            Console.WriteLine($"Division (/): {val1} / {val2} = {val1 / val2}");
            Console.WriteLine($"Modulus (%): {val1} % {val2} = {val1 % val2}");
            #endregion  // 

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}