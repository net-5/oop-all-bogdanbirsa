using System;
using System.Collections.Generic;
using System.Text;

namespace oop_all_bogdanbirsa
{
    public class Platypus : Mammal, IWalk
    {
        public Platypus(string name) : base(name)
        {
            Speed = 4;
        }
        int IWalk.Speed { get; set; }
        public void IWalk()
        {
            Console.WriteLine($"This animal is a {Name} and can walk with the max speed of {Speed} km/h!");
        }
        public void ISwim()
        {
            Console.WriteLine($"This animal is a {Name} and can swim with the max speed of {Speed} km/h!");
        }
    }
}
