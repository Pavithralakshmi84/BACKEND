using System;

namespace DelegateExamples
{
    // Task 1: Simple Delegate for Math Operation
    #region Task1_SimpleDelegate
    // One delegate type for math operations (used in Task 1 and Task 4)
    public delegate int MathOperation(int a, int b);
    #endregion

    // Task 2: Delegate with String Processing
    #region Task2_StringDelegate
    public delegate string StringOperation(string input);
    #endregion

    // Task 3: Multicast Delegate for Notifications
    #region Task3_Notifications
    public delegate void Notification();
    #endregion

    // Task 5: Multicast Delegate for Logging System
    #region Task5_Logging
    public delegate void Logger(string message);
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Delegate Examples ===\n");

            #region Task1_SimpleDelegate
            Console.WriteLine("Task 1: Simple Delegate for Math Operation");

            // Assigning delegate to methods using lambda expressions
            MathOperation add = (x, y) => x + y;
            MathOperation subtract = (x, y) => x - y;

            // Invoking delegates
            Console.WriteLine($"Add(10, 5) = {add(10, 5)}");
            Console.WriteLine($"Subtract(10, 5) = {subtract(10, 5)}\n");
            #endregion

            #region Task2_StringDelegate
            Console.WriteLine("Task 2: Delegate with String Processing");

            // Assigning delegate to string methods
            StringOperation toUpper = s => s.ToUpper();
            StringOperation reverse = s =>
            {
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                return new string(arr);
            };

            // Taking user input safely
            Console.Write("Enter a string: ");
            string? input = Console.ReadLine();
            input ??= ""; // ensure non-null

            // Invoking delegates
            Console.WriteLine($"Uppercase: {toUpper(input)}");
            Console.WriteLine($"Reversed: {reverse(input)}\n");
            #endregion

            #region Task3_Notifications
            Console.WriteLine("Task 3: Multicast Delegate for Notifications");

            // Multicast delegate: multiple methods chained together
            Notification notify = SendEmail;
            notify += SendSMS;
            notify += SendPushNotification;

            // Invoking once triggers all methods
            notify();
            Console.WriteLine();
            #endregion

            #region Task4_MethodParameter
            Console.WriteLine("Task 4: Delegate as Method Parameter");

            // Passing delegates as parameters to Process method
            Process(4, 5, add); // Addition
            Process(4, 5, (x, y) => x * y); // Multiplication
            Console.WriteLine();
            #endregion

            #region Task5_Logging
            Console.WriteLine("Task 5: Multicast Delegate for Logging System");

            // Multicast delegate for logging
            Logger logger = LogToConsole;
            logger += LogToFile;
            logger += LogToDatabase;

            // One call triggers all loggers
            logger("This is a log message.");
            Console.WriteLine();
            #endregion
        }

        #region Task3_Notifications_Methods
        static void SendEmail() => Console.WriteLine("Email sent!");
        static void SendSMS() => Console.WriteLine("SMS sent!");
        static void SendPushNotification() => Console.WriteLine("Push notification sent!");
        #endregion

        #region Task4_MethodParameter_Methods
        // Process method accepts two integers and a delegate (MathOperation)
        static void Process(int a, int b, MathOperation op)
        {
            int result = op(a, b); // Delegate decides which operation to perform
            Console.WriteLine($"Result of operation on {a} and {b} = {result}");
        }
        #endregion

        #region Task5_Logging_Methods
        static void LogToConsole(string message) => Console.WriteLine($"Console Log: {message}");
        static void LogToFile(string message) => Console.WriteLine($"File Log (simulated): {message}");
        static void LogToDatabase(string message) => Console.WriteLine($"Database Log (simulated): {message}");
        #endregion
    }
}
