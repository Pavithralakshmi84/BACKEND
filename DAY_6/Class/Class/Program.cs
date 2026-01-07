using System;

// Task 1: Student class
class Student
{
    public int rollNo;
    public string name;
    public int marks;

    public void Display()
    {
        Console.WriteLine($"Roll No: {rollNo}, Name: {name}, Marks: {marks}");
    }
}

// Task 2: Employee class
class Employee
{
    public int empId;
    public string empName;
    public double salary;

    public void Input()
    {
        Console.Write("Enter Employee ID: ");
        empId = int.Parse(Console.ReadLine());
        Console.Write("Enter Employee Name: ");
        empName = Console.ReadLine();
        Console.Write("Enter Salary: ");
        salary = double.Parse(Console.ReadLine());
    }

    public void Display()
    {
        Console.WriteLine($"ID: {empId}, Name: {empName}, Salary: {salary:C}");
    }
}

// Task 3: Inheritance - Person and Student
class Person
{
    public string name;
    public int age;

    public void DisplayPerson()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class StudentDerived : Person
{
    public int rollNo;

    public void Input()
    {
        Console.Write("Enter Name: ");
        name = Console.ReadLine();
        Console.Write("Enter Age: ");
        age = int.Parse(Console.ReadLine());
        Console.Write("Enter Roll No: ");
        rollNo = int.Parse(Console.ReadLine());
    }

    public void DisplayAll()
    {
        DisplayPerson();
        Console.WriteLine($"Roll No: {rollNo}");
    }
}

// Task 4: Multi-level Inheritance - Vehicle, Car, SportsCar
class Vehicle
{
    public string vehicleType = "Vehicle";
}

class Car : Vehicle
{
    public string carModel;
}

class SportsCar : Car
{
    public string speed;

    public void Input()
    {
        carModel = "Sports Sedan";
        speed = "300 km/h";
    }

    public void Display()
    {
        Console.WriteLine($"Type: {vehicleType}, Model: {carModel}, Top Speed: {speed}");
    }
}

// Task 5: Shape base class with Rectangle derived
class Shape
{
    public virtual void Display()
    {
        Console.WriteLine("This is a Shape");
    }
}

class Rectangle : Shape
{
    public double length;
    public double breadth;

    public Rectangle(double l, double b)
    {
        length = l;
        breadth = b;
    }

    public override void Display()
    {
        Console.WriteLine("Area of the Rectangle");
    }

    public void Area()
    {
        double area = length * breadth;
        Console.WriteLine($"Area: {area}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== DAY 5 Assignment Tasks ===\n");

        // Task 1
        Console.WriteLine("Task 1 - Student:");
        Student s1 = new Student { rollNo = 101, name = "Ravi", marks = 85 };
        s1.Display();
        Console.WriteLine();

        // Task 2
        Console.WriteLine("Task 2 - Employee:");
        Employee emp = new Employee();
        emp.Input();
        emp.Display();
        Console.WriteLine();

        // Task 3
        Console.WriteLine("Task 3 - Student Derived from Person:");
        StudentDerived sd = new StudentDerived();
        sd.Input();
        sd.DisplayAll();
        Console.WriteLine();

        // Task 4
        Console.WriteLine("Task 4 - SportsCar:");
        SportsCar sc = new SportsCar();
        sc.Input();
        sc.Display();
        Console.WriteLine();

        // Task 5
        Console.WriteLine("Task 5 - Rectangle:");
        Rectangle rect = new Rectangle(10, 5);
        rect.Display();
        rect.Area();
    }
}
