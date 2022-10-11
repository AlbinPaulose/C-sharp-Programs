using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Employee
    {
        private int age;
        private string name;

        public Employee(Employee emp)
        {
            age = emp.age;
            name = emp.name;
        }
        public Employee(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public string details
        {
            get
            {
                return "The age of " + name + " is " + age.ToString();
            }
        }
    }
    class CopyConstructor
    {
        
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(24, "Albin");
            Employee emp2 = new Employee(emp1);
            Console.WriteLine(emp2.details);
            Console.WriteLine(emp1.details);
            Console.ReadLine();


        }
    }
}
