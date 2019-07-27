using System;
using System.Collections.Generic;
using System.Text;

namespace oop_all_bogdanbirsa
{
    public class WildDuck :Bird, IFly, IWalk, ISwim
    {
        public WildDuck(string name) : base(name)
        {
            Speed = 60;
        }
        int IFly.Speed { get; set; }
        int IWalk.Speed { get; set; }
        int ISwim.Speed { get; set; }
        public void ISwim()
        {
            Console.WriteLine($"This animal is a {Name} and can swim with the max speed of {Speed} km/h!");
        }
        public void IWalk()
        {
            Console.WriteLine($"This animal is a {Name} and can walk with the max speed of {Speed} km/h!");
        }
        public void IFly()
        {
            Console.WriteLine($"This animal is a {Name} and can fly with the max speed of {Speed} km/h!");
        }
    }
}
