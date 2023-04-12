using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Encapsulation
{
    internal class Student
    {
        private string studentName, studentAge;

        public String Name
        {
            get { return studentName; }

            set { studentName = value; }
        }
        //public string StudentName { get; set; } - short code

        public String Age
        {
            get { return studentAge; }

            set { studentAge = value; }
        }
    }
}