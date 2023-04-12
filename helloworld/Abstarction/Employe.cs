using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Abstraction
{
    abstract internal class Employee
    {
        public string name;

        public abstract void GetSalary();

        public void GetEmployeeDetails()
        {
            Console.WriteLine("Employee name is: " + name);
        }
    }
}