using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid
{
    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
    }
    class StudentService
    {
        public void AddStudent(Student student)
        {
            Console.WriteLine("EXP_03");
            Console.WriteLine("Student Added Successfully");
        }
    }
    class StudentPrinter
    {
        public void PrintStudent(Student student)
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine("Roll No: " + student.RollNo);
            Console.WriteLine("Name: " + student.Name);
        }
    }
    class StudentRepository
    {
        public void SaveStudent(Student student)
        {
            Console.WriteLine("Student Saved to Database");
        }
    }

    internal class Program
    {
        static void MakeSound(IAnimal animal)
        {
            animal.Speak();   // Dog or Cat works fine
        }
        static void Main(string[] args)
        {
            Student student = new Student
            {
                RollNo = 1,
                Name = "Aditi"
            };

            StudentService service = new StudentService();
            StudentPrinter printer = new StudentPrinter();
            StudentRepository repository = new StudentRepository();

            service.AddStudent(student);
            printer.PrintStudent(student);
            repository.SaveStudent(student);



            Console.WriteLine("=== Discount Calculation System ===\n");

            DiscountCalculator calculator = new DiscountCalculator();

            Discount festival = new FestivalDiscount();
            Discount senior = new SeniorCitizenDiscount();
            Discount employee = new EmployeeDiscount();

            Console.WriteLine("\nFestival Customer:");
            Console.WriteLine("Discount = " + calculator.CalculateDiscount(festival) + "%");

            Console.WriteLine("\nSenior Citizen Customer:");
            Console.WriteLine("Discount = " + calculator.CalculateDiscount(senior) + "%");

            Console.WriteLine("\nEmployee Customer:");
            Console.WriteLine("Discount = " + calculator.CalculateDiscount(employee) + "%");

            IAnimal dog = new Dog();
            IAnimal cat = new Cat();

            MakeSound(dog);
            MakeSound(cat);

            Console.ReadLine();
        }
    }
}

