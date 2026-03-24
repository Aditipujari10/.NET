using System;

// Interface (Abstraction)
interface IEmployee
{
    void Work();
}

// Abstract Class (Abstraction)
abstract class Person
{
    // Encapsulation
    private string name;
    private int age;

    // Property
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    // Abstract Method
    public abstract void Display();
}

// Inheritance
class Employee : Person, IEmployee
{
    private double salary;

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    // Method Overriding (Runtime Polymorphism)
    public override void Display()
    {
        Console.WriteLine("EXP_02");
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Salary: " + Salary);
    }

    // Interface Implementation
    public void Work()
    {
        Console.WriteLine("Employee is working...");
    }

    // Method Overloading (Compile-time Polymorphism)
    public void CalculateBonus()
    {
        Console.WriteLine("Bonus: " + (Salary * 0.10));
    }

    public void CalculateBonus(double percentage)
    {
        Console.WriteLine("Bonus: " + (Salary * percentage / 100));
    }
}

// Main Class
class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();

        emp.Name = "Aditi";
        emp.Age = 20;
        emp.Salary = 50000;

        Console.WriteLine("OOP Concepts");
        emp.Display();        // Overriding
        emp.Work();           // Interface method
        emp.CalculateBonus(); // Overloading
        emp.CalculateBonus(20);

        Console.ReadLine();
    }
}