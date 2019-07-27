using System;
using System.Collections.Generic;
using System.Text;

namespace oop_all_bogdanbirsa
{
    public class Ostrich : Bird, IWalk
    {
        public Ostrich(string name): base(name)
        {
            Speed = 70;
        }
        int IWalk.Speed { get; set; }
        public void IWalk()
        {
            Console.WriteLine($"This animal is a {Name} and can walk with the max speed of {Speed} km/h!");

        }
    }
}
