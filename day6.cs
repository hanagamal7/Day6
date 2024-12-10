using System;

namespace Day6
{

    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        // Parameterized Constructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Parameterized Constructor initializing X and setting Y to 0
        public Point(int x) : this()
        {
            X = x;
        }

        // Overriding ToString() for custom formatting
        public override string ToString()
        {
            return $"Point: (X: {X}, Y: {Y})";
        }
    }

    // Class TypeA with different access modifiers
    public class TypeA
    {
        private string F = "Private Field";
        internal string G = "Internal Field";
        public string H = "Public Field";

        public void DisplayFields()
        {
            Console.WriteLine($"F: {F}, G: {G}, H: {H}");
        }
    }

    // Struct Employee demonstrating encapsulation
    public struct Employee
    {
        private int EmpId;
        private string Name;
        private decimal Salary;

        // Properties and methods for encapsulation
        public int GetEmpId() => EmpId;
        public void SetEmpId(int empId) => EmpId = empId;

        public string GetName() => Name;
        public void SetName(string name) => Name = name;

        public decimal GetSalary() => Salary;
        public void SetSalary(decimal salary) => Salary = salary;

        public override string ToString()
        {
            return $"Employee: {EmpId}, {Name}, {Salary:C}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point();
            Point p2 = new Point(5);
            Point p3 = new Point(7, 9);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            // Test TypeA class access modifiers
            TypeA typeA = new TypeA();
            Console.WriteLine($"H (public): {typeA.H}");
            Console.WriteLine($"G (internal): {typeA.G}");
            // Private field F can't be accessed directly here.

            // Test Employee struct
            Employee emp = new Employee();
            emp.SetEmpId(101);
            emp.SetName("John Doe");
            emp.SetSalary(75000m);
            Console.WriteLine(emp);

           



        }
    }
}
