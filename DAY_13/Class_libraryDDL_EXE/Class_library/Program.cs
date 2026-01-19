using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

#region MathUtilities
namespace MathUtilities
{
    public class Calculator
    {
        public void Add(int a, int b) => Console.WriteLine($"Sum: {a + b}");
        public void Subtract(int a, int b) => Console.WriteLine($"Difference: {a - b}");
        public void Multiply(int a, int b) => Console.WriteLine($"Product: {a * b}");
        public void Divide(int a, int b)
        {
            if (b != 0)
                Console.WriteLine($"Quotient: {(double)a / b}");
            else
                Console.WriteLine("Cannot divide by zero");
        }
    }

    public class AdvancedMath
    {
        public void Power(double x, double y) => Console.WriteLine($"Power: {Math.Pow(x, y)}");
        public void SquareRoot(double x) => Console.WriteLine($"Square Root: {Math.Sqrt(x)}");

        public void Factorial(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
                result *= i;
            Console.WriteLine($"Factorial of {n}: {result}");
        }
    }
}
#endregion

#region StudentLibrary
namespace StudentLibrary
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Marks { get; set; }

        public void CalculateGrade()
        {
            string grade;
            if (Marks >= 90) grade = "A";
            else if (Marks >= 75) grade = "B";
            else if (Marks >= 50) grade = "C";
            else grade = "F";

            Console.WriteLine($"{Name} Grade: {grade}");
        }
    }

    public class StudentService
    {
        private readonly List<Student> students = new List<Student>();

        public void AddStudent(Student s) => students.Add(s);

        public void CalculateAverageMarks()
        {
            if (students.Count == 0)
                Console.WriteLine("No students available");
            else
                Console.WriteLine($"Average Marks: {students.Average(s => s.Marks)}");
        }
    }
}
#endregion

#region BankLibrary
namespace BankLibrary
{
    public abstract class Account
    {
        public string AccountNumber { get; protected set; } = string.Empty;
        public double Balance { get; protected set; }

        protected Account(string accountNumber, double initialBalance = 0)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0) Balance += amount;
            Console.WriteLine($"Deposited: {amount}, New Balance: {Balance}");
        }

        public virtual void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}, New Balance: {Balance}");
            }
            else
                Console.WriteLine("Insufficient balance");
        }

        public void CheckBalance() => Console.WriteLine($"Balance: {Balance}");
    }

    public class SavingsAccount : Account
    {
        public SavingsAccount(string accountNumber, double initialBalance = 0)
            : base(accountNumber, initialBalance) { }

        public override void Withdraw(double amount)
        {
            if (Balance - amount >= 100)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}, New Balance: {Balance}");
            }
            else
                Console.WriteLine("Minimum balance rule violated");
        }
    }

    public class CurrentAccount : Account
    {
        public CurrentAccount(string accountNumber, double initialBalance = 0)
            : base(accountNumber, initialBalance) { }
    }
}
#endregion

#region LoggerLibrary
namespace LoggerLibrary
{
    public class Logger
    {
        public void LogInfo(string message)
        {
            Console.WriteLine($"INFO: {message}");
            File.AppendAllText("log.txt", $"INFO: {message}\n");
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"WARNING: {message}");
            File.AppendAllText("log.txt", $"WARNING: {message}\n");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"ERROR: {message}");
            File.AppendAllText("log.txt", $"ERROR: {message}\n");
        }
    }
}
#endregion

#region PayrollLibrary
namespace PayrollLibrary
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public double BasicSalary { get; set; }

        public Employee(int id, string name, double basicSalary)
        {
            EmployeeId = id;
            Name = name;
            BasicSalary = basicSalary;
        }
    }

    public class PayrollCalculator
    {
        public void CalculateNetSalary(Employee emp)
        {
            double hra = emp.BasicSalary * 0.20;
            double da = emp.BasicSalary * 0.10;
            double tax = emp.BasicSalary * 0.05;

            double netSalary = emp.BasicSalary + hra + da - tax;
            Console.WriteLine($"Net Salary of {emp.Name}: {netSalary}");
        }
    }
}
#endregion

#region ProgramDemo
class Program
{
    static void Main()
    {
        // Math Demo
        var calc = new MathUtilities.Calculator();
        calc.Add(5, 3);
        calc.Subtract(5, 3);
        calc.Multiply(5, 3);
        calc.Divide(5, 3);

        var adv = new MathUtilities.AdvancedMath();
        adv.Factorial(5);
        adv.Power(2, 3);
        adv.SquareRoot(16);

        // Student Demo
        var student = new StudentLibrary.Student { Id = 1, Name = "Pavithra", Marks = 85 };
        student.CalculateGrade();

        var service = new StudentLibrary.StudentService();
        service.AddStudent(student);
        service.CalculateAverageMarks();

        // Bank Demo
        var savings = new BankLibrary.SavingsAccount("S123", 500);
        savings.Deposit(200);
        savings.Withdraw(300);
        savings.CheckBalance();

        // Logger Demo
        var logger = new LoggerLibrary.Logger();
        logger.LogInfo("Application started");

        // Payroll Demo
        var emp = new PayrollLibrary.Employee(101, "Arun", 30000);
        var payroll = new PayrollLibrary.PayrollCalculator();
        payroll.CalculateNetSalary(emp);
        Console.ReadKey();
    }
}
#endregion
