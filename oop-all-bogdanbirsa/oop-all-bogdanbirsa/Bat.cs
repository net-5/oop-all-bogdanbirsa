using System;
using System.Collections.Generic;
using System.Text;

namespace oop_all_bogdanbirsa
{
    public class Bat :Mammal, IFly
    {
        public Bat(string name) : base(name)
        {
            Speed = 160;
        }
        int IFly.Speed { get; set; }
        public void IFly()
        {
            Console.WriteLine($"This animal is a {Name} and can fly with the max speed of {Speed} km/h!");
        }
    }
}
