using System;

#region   (Static Class)
public static class Test1
{
    public static void Addition(int a, int b)
    {
        Console.WriteLine($"Addition: {a + b}");
    }

    public static void Subtraction(int a, int b)
    {
        Console.WriteLine($"Subtraction: {a - b}");
    }
}
#endregion

#region Test2 - Multiplication and Division (Sealed Class)
public sealed class Test2
{
    public void Multiplication(int a, int b)
    {
        Console.WriteLine($"Multiplication: {a * b}");
    }

    public void Division(int a, int b)
    {
        Console.WriteLine($"Division: {a / b}");
    }
}
#endregion

#region  (Abstract Class)
public abstract class Test3
{
    public abstract void Rectangle(int l, int b);
    public abstract void Square(int side);
}

public class Test03 : Test3
{
    public override void Rectangle(int l, int b)
    {
        Console.WriteLine($"Rectangle Area: {l * b}");
    }

    public override void Square(int side)
    {
        Console.WriteLine($"Square Area: {side * side}");
    }
}
#endregion

#region (Virtual Override)
public class Test4
{
    public virtual void Circle(double radius)
    {
        double area = 3.14 * radius * radius;
        Console.WriteLine($"Circle Area (Base): {area}");
    }
}

public class Test5 : Test4
{
    public override void Circle(double radius)
    {
        double area = 3.14 * radius * radius;
        Console.WriteLine($"Circle Area (Override): {area}");
    }
}
#endregion

#region (Access Specifiers )
public class Test5Access
{
    public int publicVar = 10;
    protected int protectedVar = 20;
    internal int internalVar = 30;
    protected internal int protInternalVar = 40;
    private int privateVar = 50;

    public void ShowPrivate()
    {
        Console.WriteLine($"Private: {privateVar}");
    }
}

public class DerivedTest5 : Test5Access
{
    public void Output()
    {
        Console.WriteLine("=== Test5 Access Specifiers ===");
        Console.WriteLine($"Public: {publicVar}");
        Console.WriteLine($"Protected: {protectedVar}");
        Console.WriteLine($"Internal: {internalVar}");
        Console.WriteLine($"Protected Internal: {protInternalVar}");
      

    }
}
#endregion

#region Program Entry Point
class Program
{
    static void Main()
    {
        Console.WriteLine("Static Class ");
        Test1.Addition(10, 5);     
        Test1.Subtraction(10, 5);  

        Console.WriteLine("\n=== Sealed Class ===");
        var test2 = new Test2();
        test2.Multiplication(6, 4);   
        test2.Division(20, 4);      

        Console.WriteLine("\n=== Abstract Class  ===");
        var test3 = new Test03();
        test3.Rectangle(15, 10);      
        test3.Square(8);             

        Console.WriteLine("\n===  Virtual Class .(over riding) ===");
        Test4 circleBase = new Test4();
        circleBase.Circle(5);        

        Test5 circleOverride = new Test5();
        circleOverride.Circle(5);    

        Console.WriteLine("\n=== private, internal, Protected, Protected internal,Public ===");
        var access = new Test5Access();
        access.ShowPrivate();

        var derived = new DerivedTest5();
        derived.Output();

          }
}
#endregion
