using System;
using System.Collections.Generic;
using System.Text;

namespace oop_all_bogdanbirsa
{
    public class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
        }
        public void Fly()
        {
            Console.WriteLine($"This {Name} if bird and can fly");
        }
    }
}
