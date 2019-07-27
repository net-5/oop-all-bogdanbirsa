using System;
using System.Collections.Generic;
using System.Text;

namespace oop_all_bogdanbirsa
{
    public class Reptile :Animal
    {
        public Reptile(string name) :base(name)
        {
        }
        public void Crawl()
        {
            Console.WriteLine($"This {Name} is reptile and can crawl");
        }
    }
}
