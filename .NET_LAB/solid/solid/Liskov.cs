using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid
{
    interface IAnimal
    {
        void Speak();
    }

    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Cat meows");
        }
    }

    internal class Liskov
    {

    }
}
