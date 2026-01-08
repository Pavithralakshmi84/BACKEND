using System;

namespace InheritanceAndOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
          
            #region Employee Demo
            Employee emp = new Employee();
            emp.InputDetails();   
            emp.DisplayDetails(); 
            #endregion

           
            #region Vehicle Demo
            SportsCar sc = new SportsCar("Sports Car");
            sc.DisplayDetails();
            #endregion

           
            #region Shape & Rectangle Demo
            Rectangle rect = new Rectangle(10, 5);
            rect.Display();
            #endregion

           
            #region Account Demo
            SavingsAccount sa = new SavingsAccount(12345, 5000);
            sa.DisplayDetails();
            #endregion

            
            #region Device Demo
            SmartPhone sp = new SmartPhone("Device", "Samsung Galaxy", "Android");
            sp.DisplayDetails();
            #endregion

           
            #region Area Overloading Demo
            Area area = new Area();
            Console.WriteLine("Square Area: " + area.CalculateArea(5));       // Square
            Console.WriteLine("Rectangle Area: " + area.CalculateArea(10, 4)); // Rectangle
            Console.WriteLine("Circle Area: " + area.CalculateArea(7.0));      // Circle
            #endregion

            
            #region Shape Overloading Demo
            Shape shape = new Shape();
            shape.Draw(5);             // Circle
            shape.Draw(10, 4);         // Rectangle
            shape.Draw(6, 8, 10);      // Triangle
            #endregion
        }
    }

    #region Employee Class
    class Employee
    {
        private int empId;
        private string empName = ""; 
        private double salary;

        public void InputDetails()
        {
            Console.Write("Enter Employee ID: ");
            empId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            empName = Console.ReadLine() ?? "";

            Console.Write("Enter Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Employee ID: {empId}, Name: {empName}, Salary: {salary}");
        }
    }
    #endregion

    #region Vehicle Classes
    class Vehicle
    {
        protected string vehicleType;
        public Vehicle(string type)
        {
            vehicleType = type;
        }
    }

    class Car : Vehicle
    {
        public Car(string type) : base(type) { }
    }

    class SportsCar : Car
    {
        public SportsCar(string type) : base(type) { }

        public void DisplayDetails()
        {
            Console.WriteLine($"Vehicle Type: {vehicleType}");
        }
    }
    #endregion

    #region Shape & Rectangle Classes
    class ShapeBase
    {
        public virtual void Display()
        {
            Console.WriteLine("This is a shape.");
        }
    }

    class Rectangle : ShapeBase
    {
        private int length;
        private int breadth;

        public Rectangle(int l, int b)
        {
            length = l;
            breadth = b;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Rectangle Area: {length * breadth}");
        }
    }
    #endregion

    #region Account Classes
    class Account
    {
        protected int accountNo;
        public Account(int accNo)
        {
            accountNo = accNo;
        }
    }

    class SavingsAccount : Account
    {
        private double balance;

        public SavingsAccount(int accNo, double bal) : base(accNo)
        {
            balance = bal;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Account No: {accountNo}, Balance: {balance}");
        }
    }
    #endregion

    #region Device Classes
    class Device
    {
        protected string deviceName;
        public Device(string name)
        {
            deviceName = name;
        }
    }

    class Mobile : Device
    {
        protected string model;
        public Mobile(string name, string model) : base(name)
        {
            this.model = model;
        }
    }

    class SmartPhone : Mobile
    {
        private string os;
        public SmartPhone(string name, string model, string os) : base(name, model)
        {
            this.os = os;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Device: {deviceName}, Model: {model}, OS: {os}");
        }
    }
    #endregion

    #region Area Class with Overloading
    class Area
    {
        public int CalculateArea(int side) // Square
        {
            return side * side;
        }

        public int CalculateArea(int length, int breadth) // Rectangle
        {
            return length * breadth;
        }

        public double CalculateArea(double radius) // Circle
        {
            return Math.PI * radius * radius;
        }
    }
    #endregion

    #region Shape Class with Overloading
    class Shape
    {
        // Circle
        public void Draw(int radius)
        {
            Console.WriteLine($"Drawing a Circle with radius {radius}");
        }

        // Rectangle
        public void Draw(int length, int breadth)
        {
            Console.WriteLine($"Drawing a Rectangle with length {length} and breadth {breadth}");
        }

        // Triangle
        public void Draw(int side1, int side2, int side3)
        {
            Console.WriteLine($"Drawing a Triangle with sides {side1}, {side2}, {side3}");
        }
    }
    #endregion
}
