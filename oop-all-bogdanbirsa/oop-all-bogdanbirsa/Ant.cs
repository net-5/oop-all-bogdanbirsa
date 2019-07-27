using System;
using System.Collections.Generic;
using System.Text;

namespace oop_all_bogdanbirsa
{
    public class Ant : Insect, IWalk
    {
        public Ant(string name) :base (name)
        {
            Speed = 15;
        }
        int IWalk.Speed { get; set; }

        public void IWalk()
        {
            Console.WriteLine($"This insect is a {Name} and can walk with the max speed of {Speed} km/h!");
        }
    }
}
