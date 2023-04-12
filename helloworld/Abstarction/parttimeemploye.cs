using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Abstraction
{
    internal class ParttimeEmployee : Employee
    {
        public override void GetSalary()
        {
            Console.WriteLine("Employee salary is: 50,000");
        }
    }
}