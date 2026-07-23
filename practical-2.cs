using System;

// Interface
interface IPayroll
{
    void CalculateSalary();
}

// Base Class
class Employee
{
    public string Name;
    public int Id;

    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public virtual void Display()
    {
        Console.WriteLine("Employee ID   : " + Id);
        Console.WriteLine("Employee Name : " + Name);
    }
}

// Derived Class
class PermanentEmployee : Employee, IPayroll
{
    double BasicSalary;

    public PermanentEmployee(string name, int id, double salary)
        : base(name, id)
    {
        BasicSalary = salary;
    }

    // Interface Method
    public void CalculateSalary()
    {
        double NetSalary = BasicSalary + (0.20 * BasicSalary);
        Console.WriteLine("Net Salary : " + NetSalary);
    }

    // Method Overriding (Polymorphism)
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Employee Type : Permanent");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Base class reference (Runtime Polymorphism)
        Employee emp = new PermanentEmployee("Raj", 101, 50000);

        emp.Display();

        IPayroll payroll = (IPayroll)emp;
        payroll.CalculateSalary();

        Console.ReadKey();
    }
}
