using System;
using System.Collections.Generic;
using System.Text;

namespace oop_all_bogdanbirsa
{
    public class Snake :Reptile,ICrawl, ISwim
    {
        public Snake(string name):base (name)
        {
            Speed = 15;
        }
        int ICrawl.Speed { get; set; }
        int ISwim.Speed { get; set; }

        public void ICrawl()
        {
            Console.WriteLine($"This animal is a {Name} and can crowl with the max speed of {Speed} km/h!");
        }
        public void ISwim()
        {
            Console.WriteLine($"This animal is a {Name} and can swim with the max speed of {Speed} km/h!");
        }
    }
}
