using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.variables
            string name = "Aditi";
            Console.WriteLine(name);

            int myNum = 14;
            double myDoubleNum = 5.987D;
            char letter = 'D';
            bool muBool = true;
            string text = "Hello";

            const int a = 10;
            //a = 90;  error

            string Fname = "Aditi";
            string Lname = "Pujari";
            Console.WriteLine("My name is " + Fname + " " + Lname);

            //multiple variables 
            int A= 10, b = 10, c = 30;
            Console.WriteLine(A + b + c);

            //type casting
            int i = 7;
            double d = i;
            double dou = 7.88;
            Console.WriteLine(d);
            Console.WriteLine(d.GetType());
            Console.WriteLine(Convert.ToInt32(dou));

            //user input
            Console.WriteLine("Enter username : ");
            string userName = Console.ReadLine();
            Console.WriteLine("UserName is : " + userName);

            Console.WriteLine("Enter Age : ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age is : " + Age);

            //Arithmatic operation
            Console.WriteLine("Exp_01");
            Console.WriteLine("Arithmetic Operations : ");
            int num1 = 20;
            int num2 = 90;
            Console.WriteLine("Addition : " + (num1 + num2));
            Console.WriteLine("Substraction : " + (num1 - num2));
            Console.WriteLine("Multiplication : " + (num1 * num2));
            Console.WriteLine("Division : " + (num1 / num2));
            Console.WriteLine("Modulus : "+ (num2 % num2));

            //Assignment operations
            int num3 = 10;
            num3 += 20;
            num3 -= 30;
            Console.WriteLine(num3);

            //comparison operation
            Console.WriteLine("Comparision Operations : ");
            int n1 = 4;
            int n2 = 7;
            Console.WriteLine("n1 > n2 : " + (n1 > n2));
            Console.WriteLine("n1 < n2 : "+ (n1 < n2));
            Console.WriteLine("n1 >= n2 : "+ (n1 >= n2));
            Console.WriteLine("n1 <= n2 : "+ (n1 <= n2));
            Console.WriteLine("n1 != n2 : " + (n1 != n2));
            Console.WriteLine("n1 == n2 : " + (n1 == n2));

            //logical 
            Console.WriteLine((n1 > n2) && (n1 == n2));
            Console.WriteLine(2 == 9 || 6 > 3);
            Console.WriteLine(!true);

            //math
            double nu1 = Math.Min(6, 7);
            double nu2 = Math.Sqrt(64);
            Console.WriteLine(nu1);
            Console.WriteLine(nu2);

            //string 
            string txt = "Hello World";
            Console.WriteLine(txt.Length);
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());

            Console.WriteLine($"My name is: {Fname} {Lname}");
            //accress string
            Console.WriteLine(txt[4]);
            Console.WriteLine(txt[7]);
            Console.WriteLine(txt.IndexOf("H"));

            Console.WriteLine("I am learning in \'DKTE\' collage in \"AIML\" branch. ");

            //if
            int m = 90;
            int n = 80;
            if (m > n)
            {
                Console.WriteLine($"{m} is greater");
            }

            //if-else
            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age > 18)
            {
                Console.WriteLine("Is adult");
            }
            else
            {
                Console.WriteLine("Is not adult");
            }

            //switch
            int day = 6;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default: 
                    Console.WriteLine("Wrong choice");
                    break;
            }

            //loops
            for( i= 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }

            int[] a1 = { 1, 2, 3, 4, 5 };
            //foreachloop
            foreach (var item in a1)
            {
                Console.WriteLine(item);
            }


            //break

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 4)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //array
            string[] cars = { "BMW", "Audi", "Thar" };
            foreach (var item in cars)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }



        }
    }
}
