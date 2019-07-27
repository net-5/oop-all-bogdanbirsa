using System;
using System.Collections.Generic;
using System.Text;

namespace oop_all_bogdanbirsa
{
    public class Fish : Animal
    {
        public Fish(string name) : base(name)
        {
        }
        public void Swim()
        {
            Console.WriteLine($"This {Name} is a fish and can swim");
        }
    }
}
