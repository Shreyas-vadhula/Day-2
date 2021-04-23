using System;

namespace Sample_8
{
    class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
         
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.EmpId = 101;
            emp1.Name = "dddd";

            Employee emp2 = new Employee();
            emp2.EmpId = 102;
            emp2.Name = "ddd";

            Console.WriteLine(emp1.Equals(emp2));
            Console.WriteLine(Equals(emp1, emp2));
            Console.ReadLine();
        }
    }
}
