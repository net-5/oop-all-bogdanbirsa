using System;
using System.Collections.Generic;
using System.Text;

namespace oop_all_bogdanbirsa
{
    public class Animal
    {
        public string name;
        internal int Speed;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Animal(string name)
        {
            Name = name;
        }
    }
}
