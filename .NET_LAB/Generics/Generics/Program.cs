using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generics allow us to define classes ,methods or collections with a place holder for a datatype so they work with any type while maintaining type sefty
            ArrayList list = new ArrayList();
            
            list.Add(10);
            list.Add(20);
            list.Add("c#");

            //generics collection
            List<int> num = new List<int>();
            num.Add(10);
            num.Add(20);

            //generics class

            myclass<int> obj = new myclass<int>();
            obj.data = 20;

            myclass<string> obj2 = new myclass<string>();
            obj2.data = "Aditi";


        }
    }
    class myclass<T>
    {
        public T data;

        public void show()
        {
            Console.WriteLine(data);
        }
    }
}

//activity
//1.write a 2 example for generics
//2.real time example where we use generics in company lavels
//3.why company use gerneric (typesefaty)


//lamda expression is short way of writting anonoumous method using arrow operator
//(parameter) => expression


//activitiy
//1.write a 2 example with lamda expression 
//2.where we use in compny lavele
//3.create a generic class to store two valus 
//what is  generics
//why generics is better that arraylist
//what is lamda expression
//diff delegate between lamda

//sychrouns and ayschrouns programmimg in c#
