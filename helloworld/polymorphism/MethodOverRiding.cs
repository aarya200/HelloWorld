using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Polymorphism
{
    internal class Animal
    {
        internal string name;

        public virtual void Run()
        {
            Console.WriteLine("Running Slow");
        }
        public void AnimalDetails()
        {
            Console.WriteLine("Name of the Animal: " + name);
        }
    }
    class Lion : Animal
    {
        public override void Run()
        {
            Console.WriteLine("Running Fast");
        }
    }
}

