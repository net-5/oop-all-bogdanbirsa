using System;
using System.Collections.Generic;
using System.Text;

namespace oop_all_bogdanbirsa
{
    public class Insect : Animal
    {
        public Insect(string name) : base(name)
        {
        }
        public void Fly()
        {
            Console.WriteLine($"This {Name} is a insect and can fly");
        }
    }
}
