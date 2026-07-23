using System;

class Student
{
    // Private data members (Encapsulation)
    private int studentId;
    private string studentName;
    private string course;

    // Parameterized Constructor
    public Student(int id, string name, string courseName)
    {
        studentId = id;
        studentName = name;
        course = courseName;
    }

    // Public method to display student details
    public void DisplayDetails()
    {
        Console.WriteLine("Student ID   : " + studentId);
        Console.WriteLine("Student Name : " + studentName);
        Console.WriteLine("Course       : " + course);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Object Creation
        Student s1 = new Student(101, "Raj", "Computer Engineering");

        Console.WriteLine("Student Admission Details");
        Console.WriteLine("-------------------------");
        s1.DisplayDetails();

        Console.ReadKey();
    }
}
