// See https://aka.ms/new-console-template for more information
using HelloWorld.Abstraction;
using HelloWorld.Encapsulation;
using HelloWorld.Inheritance;
using HelloWorld.Polymorphism;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to My Program!");
            Console.WriteLine("Please choose any one program from below options:");
            Console.WriteLine("1.Human\n2.Inheritance\n3.Method Overloading\n4.Method Overriding\n5.Employee Details\n6.Encapsulation");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    //object or instance syntax
                    //ClassName variable=new ClassName();
                    Human human = new Human();
                    //display msg on output screen
                    Console.WriteLine("Please enter human name");
                    human.name = Console.ReadLine();
                    //reading input from output screen
                    Console.WriteLine("Please enter your height");
                    human.height = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Please enter your weight");
                    human.weight = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Please enter your age");
                    human.age = Convert.ToInt32(Console.ReadLine());
                    human.Speak();
                    human.Walk();
                    human.HumanDetails(human.name, human.height, human.weight, human.age);
                    break;
                case 2:
                    Car car = new Car();
                    Console.WriteLine("Enter model number");
                    car.modelNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter brand name");
                    car.brand = Console.ReadLine();
                    car.Start();
                    break;
                case 3:
                    Addition addition = new Addition();
                    Console.WriteLine("Enter double value: ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter integer value: ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter integer value: ");
                    int z = Convert.ToInt32(Console.ReadLine());
                    addition.AddNumbers(x, y, z);
                    break;
                case 4:
                    Animal animal = new Animal();
                    //Console.WriteLine("Please enter animal name");
                    //animal.name = Console.ReadLine();
                    animal.name = "Elephant";
                    animal.AnimalDetails();
                    animal.Run();

                    Lion lion = new Lion();
                    //Console.WriteLine("Please enter animal name");
                    lion.name = "Lion";
                    lion.AnimalDetails();
                    lion.Run();
                    break;
                case 5:
                    ParttimeEmployee employee = new ParttimeEmployee();
                    Console.WriteLine("Enter employee name");
                    employee.name = Console.ReadLine();
                    employee.GetEmployeeDetails();
                    employee.GetSalary();
                    break;
                case 6:
                    Student student = new Student();
                    Console.WriteLine("Please enter student name:");
                    student.Name = Console.ReadLine();
                    //Console.WriteLine(student.Name);
                    Console.WriteLine("Please enter student age:");
                    student.Age = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Student name is {0} and age is {1} ", student.Name, student.Age);
                    //Console.WriteLine(student.Age);
                    break;
                default:
                    Console.WriteLine("Please choose program from given options");
                    break;
            }
            Console.ReadLine();

        }
    }
}
