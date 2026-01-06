using System;

#region Employee Class
class Employee
{
    public int Id;
    public string Name;
    public double Salary;

    public void DisplayDetails()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}");
    }
}
#endregion

#region Sample Class (Accessing own members)
class Sample
{
    private int number;

    public void SetNumber(int n, int m)
    {
        number = m + n;
    }

    public void Add()
    {
        Console.WriteLine("Sum of two numbers : " + number);
    }
}
#endregion

#region Two Sample Classes
class SampleA
{
    public int val1 = 100;
    int val2 = 90;

    public void ShowA()
    {
        Console.WriteLine($"Subtraction: {val1 - val2}");
    }
}

class SampleB
{
    public int num1 = 200;
    int num2 = 20;

    public void ShowB()
    {
        Console.WriteLine($"Multiply: {num1 * num2}");
    }

    public void SampleA(SampleA obj)
    {
        Console.WriteLine("Accessing SampleA Value: " + obj.val1);
        obj.ShowA();
    }
}
#endregion

class Program
{
    static void Main(string[] args)
    {
    
        Employee emp = new Employee { Id = 1, Name = "Pavithra", Salary = 50000 };
        emp.DisplayDetails();

       
        Sample s = new Sample();
        s.SetNumber(10, 20);
        s.Add();

    
        SampleA a = new SampleA();
        SampleB b = new SampleB();
        b.SampleA(a);
        b.ShowB();
    }
}
