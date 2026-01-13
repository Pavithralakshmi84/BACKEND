using System;
using System.IO;

#region Task 1: MyUtilities Namespace
namespace MyUtilities
{
    public class MathHelper
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
#endregion

#region Task 4: Custom Exception
public class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message) { }
}
#endregion

#region Task 5: StudentData Namespace
namespace StudentData
{
    public class StudentFileHandler
    {
        private string filePath;

        public StudentFileHandler(string fileName)
        {
            filePath = fileName;
        }

        public void WriteStudents(string[] students)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    foreach (string student in students)
                    {
                        writer.WriteLine(student);
                    }
                    Console.WriteLine("Students saved successfully");
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("No permission to write file");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Write error: " + ex.Message);
            }
        }

        public void ReadStudents()
        {
            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException("Student file not found");

                using (StreamReader reader = new StreamReader(filePath))
                {
                    Console.WriteLine("Student List:");
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine("  - " + line);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Read error: " + ex.Message);
            }
        }
    }
}
#endregion

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C# Beginner Tasks - Complete Program\n");

        #region Task 1 - Namespace Demo
        Console.WriteLine("TASK 1: NAMESPACE");
        MyUtilities.MathHelper math = new MyUtilities.MathHelper();
        int result = math.Add(15, 25);
        Console.WriteLine("15 + 25 = " + result + "\n");
        #endregion

        #region Task 2 - File Writing
        Console.WriteLine("TASK 2: FILE STREAM WRITING");
        string messageFile = "message.txt";
        using (FileStream fs = new FileStream(messageFile, FileMode.Create))
        using (StreamWriter writer = new StreamWriter(fs))
        {
            writer.WriteLine("Hello C# Streams");
            Console.WriteLine("message.txt created with streams");
        }
        Console.WriteLine();
        #endregion

        #region Task 3 - File Reading
        Console.WriteLine("TASK 3: FILE READING + EXCEPTIONS");
        try
        {
            string content = File.ReadAllText(messageFile);
            Console.WriteLine("File content: " + content);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("message.txt not found");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        Console.WriteLine();
        #endregion

        #region Task 4 - Custom Exception
        Console.WriteLine("TASK 4: CUSTOM EXCEPTION");
        try
        {
            Console.Write("Enter a positive number: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
                throw new NegativeNumberException("Negative numbers not allowed!");
            Console.WriteLine("Good number: " + number);
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine("Custom Error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid number only");
        }
        Console.WriteLine();
        #endregion

        #region Task 5 - Combined Features
        Console.WriteLine("TASK 5: STUDENT FILE HANDLER");
        StudentData.StudentFileHandler handler = new StudentData.StudentFileHandler("students.txt");
        handler.WriteStudents(new string[] { "Ravi Kumar", "Priya Sharma", "Arun Patel" });
        handler.ReadStudents();
        #endregion

     
        Console.WriteLine("Files created: message.txt, students.txt");
        Console.ReadKey();
    }
}
