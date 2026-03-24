using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static @delegate.Program;

namespace @delegate
{
    internal class Program
    {
        public delegate void myDelegate();
        delegate void MyDelegate(string msg);

        public static void function1()
        {
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
        static void Main(string[] args)
        {
            //activity 1
            myDelegate d = function1;
            d -= function2;

            d += function3;
            d();

            //activity 2
            MyDelegate del = (msg) =>
            {
                Console.WriteLine("First: " + msg);
            };
            del += (msg) =>
            {
                Console.WriteLine("Second: " + msg);
            };
            del("Hello Lambda!");


            //activity 3
            List<int> nums = new List<int> { 5, 2, 8, 1, 3 };

            nums.Sort((a, b) => a.CompareTo(b));
            Console.WriteLine("Ascending:");
            foreach (int n in nums)
                Console.Write(n + " ");

            nums.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine("\nDescending:");
            foreach (int n in nums)
                Console.Write(n + " ");
        }
        
    }
}
