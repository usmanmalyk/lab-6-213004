using System;

// Define an enumeration for the Department
public enum Department
{
    ComputerScience,
    Mathematics,
    Physics,
    Chemistry
}

// Base class: Person
class Person
{
    public string Name { get; set; }

    public Person()
    {
        // Initialize instance variables with default values
        Name = null;
    }

    public Person(string name)
    {
        Name = name;
    }
}

// Derived class: Student
class Student : Person
{
    public string RegNo { get; set; }
    public int Age { get; set; }
    public Department Program { get; set; }

    public Student()
    {
        // Initialize instance variables with different default values
        RegNo = "N/A";
        Age = 18; // Default age set to 18
        Program = Department.ComputerScience;
    }

    public Student(string name, string regNo, int age, Department program)
        : base(name)
    {
        RegNo = regNo;
        Age = age;
        Program = program;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a Student object using the parameterized constructor
        Student student1 = new Student("Usman Hanif", "12345", 20, Department.Physics);

        // Accessing and displaying the properties
        Console.WriteLine("Student Information:");
        Console.WriteLine("Name: " + student1.Name);
        Console.WriteLine("RegNo: " + student1.RegNo);
        Console.WriteLine("Age: " + student1.Age);
        Console.WriteLine("Program: " + student1.Program);

        // Creating a Student object using the default constructor
        Student student2 = new Student();

        Console.WriteLine("\nStudent 2 Information (Default Values):");
        Console.WriteLine("Name: " + student2.Name);
        Console.WriteLine("RegNo: " + student2.RegNo);
        Console.WriteLine("Age: " + student2.Age);
        Console.WriteLine("Program: " + student2.Program);
    }
}