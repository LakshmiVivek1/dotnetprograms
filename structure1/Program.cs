using System;

namespace StructExample
{
    class Program
    {
        public struct Employee
        {
            int id;
            double salary;

            public Employee(int id, double salary)
            {
                this.id = id;
                this.salary = salary;
            }

            public Employee(int id, int salary)
            {
                this.id = id;
                this.salary = 3400.00;
            }

            public Employee(Employee x)
            {
                this.id = x.id;
                this.salary = x.salary;
            }

            public void DisplayValues()
            {
                Console.WriteLine("Structure");
                Console.WriteLine("ID: " + this.id.ToString());
                Console.WriteLine("Salary: " + this.salary.ToString());
            }
        }

        static void Main(string[] args)
        {
            Employee emp = new Employee(12, 4560.00);
            emp.DisplayValues();
            Console.ReadLine();
        }
    }
}

