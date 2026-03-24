using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    //public Delegate void myDelegate();
    
    internal class Program
    {
        public delegate void myDelegate();

        public static void function1()
        {
            Console.WriteLine("Exp_04");
            Console.WriteLine("Function 1 Called");

        }

        public static void function2()
        {
            Console.WriteLine("Function 2 Called");

        }

        public static void function3()
        {
            Console.WriteLine("Function 3 called");
        }
        //public static void function1()
        //{
        //    Console.WriteLine("Function1 called");
        //}
        //public static void function2() 
        //{
        //    Console.WriteLine("Function2 called");
        //}

        static void Main(string[] args)
        {
            //myDelegate del = function1;
            //del();
            //del += function2;
            //del();

            myDelegate d = function1;
            d += function2;

            d += function3;
            d();

        }
    }
}
