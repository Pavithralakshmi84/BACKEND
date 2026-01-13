using System;
using System.Collections.Generic;

#region  

public class Vehicle
{
    public string Model { get; set; }
    public int MaxSpeed { get; set; }

    
    public Vehicle()
    {
        Console.WriteLine("Vehicle");
    }

    // Constructor with one parameter
    public Vehicle(string model)
    {
        Model = model;
        Console.WriteLine($"Vehicle constructor with model: {model}");
    }

    // Constructor with two parameters
    public Vehicle(string model, int maxSpeed)
    {
        Model = model;
        MaxSpeed = maxSpeed;
        Console.WriteLine($"Vehicle constructor with model: {model}, maxSpeed: {maxSpeed}");
    }

    public virtual void Start()
    {
        Console.WriteLine($"{Model} vehicle started");
    }
}

public class Car : Vehicle
{
    public int Doors { get; set; }

    public Car(string model, int maxSpeed, int doors) : base(model, maxSpeed)
    {
        Doors = doors;
    }

    public override void Start()
    {
        Console.WriteLine($"{Model} car with {Doors} doors started");
    }
}

public class Bike : Vehicle
{
    public bool HasSidecar { get; set; }

    public Bike(string model, bool sidecar) : base(model)
    {
        HasSidecar = sidecar;
    }

    public override void Start()
    {
        Console.WriteLine($"{Model} bike {(HasSidecar ? "with sidecar" : "without sidecar")} started");
    }
}

#endregion

#region Payment System Polymorphism (Overriding)

public abstract class Payment
{
    public abstract void MakePayment(double amount);
}

public class CreditCard : Payment
{
    public override void MakePayment(double amount)
    {
        Console.WriteLine($"Paid {amount} via Credit Card - charged with 2% fee");
    }
}

public class NetBanking : Payment
{
    public override void MakePayment(double amount)
    {
        Console.WriteLine($"Paid {amount} via NetBanking - instant transfer");
    }
}

public class UPI : Payment
{
    public override void MakePayment(double amount)
    {
        Console.WriteLine($"Paid {amount} via UPI - QR scan completed");
    }
}

#endregion

#region Shape Calculator Interface

public interface IShape
{
    double GetArea();
}

public class Square : IShape
{
    public double Side { get; set; }

    public Square(double side)
    {
        Side = side;
    }

    public double GetArea()
    {
        return Side * Side;
    }
}

public class Circle : IShape
{
    public double Radius { get; set; }
    private const double PI = 3.14159;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return PI * Radius * Radius;
    }
}

#endregion

#region Media Player Interfaces

public interface IPlayable
{
    void Play();
    void Stop();
}

public interface IRecordable
{
    void Record();
}

public class Smartphone : IPlayable, IRecordable
{
    public void Play()
    {
        Console.WriteLine("Smartphone: Playing music/video");
    }

    public void Stop()
    {
        Console.WriteLine("Smartphone: Stopped playback");
    }

    public void Record()
    {
        Console.WriteLine("Smartphone: Recording video/audio");
    }
}

public class OldRadio : IPlayable
{
    public void Play()
    {
        Console.WriteLine("OldRadio: Playing radio station");
    }

    public void Stop()
    {
        Console.WriteLine("OldRadio: Stopped radio");
    }
}

#endregion

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== 1. Vehicle Hierarchy ===");
        Vehicle car = new Car("Toyota", 180, 4);
        car.Start();

        Vehicle bike = new Bike("Honda", true);
        bike.Start();

        Console.WriteLine("\n=== 2. Payment Polymorphism ===");
        Payment[] payments = { new CreditCard(), new NetBanking(), new UPI() };
        foreach (Payment p in payments)
        {
            p.MakePayment(1000.0);
        }

        Console.WriteLine("\n=== 3. Shape Calculator ===");
        List<IShape> shapes = new List<IShape>
        {
            new Square(5),
            new Circle(3)
        };
        foreach (IShape shape in shapes)
        {
            Console.WriteLine($"Area: {shape.GetArea():F2}");
        }

        Console.WriteLine("\n=== 4. Media Player ===");
        IPlayable radio = new OldRadio();
        radio.Play();
        radio.Stop();

        Smartphone phone = new Smartphone();
        phone.Play();
        phone.Stop();
        phone.Record();

       
    }
}
