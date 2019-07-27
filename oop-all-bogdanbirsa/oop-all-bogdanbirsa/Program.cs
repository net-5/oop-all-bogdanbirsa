using System;

/*Make an application where to model a animals keeping in mind that:
- any kind you model is an animal
- any animal has a name
- there are multiple animal categories like : mammals, fish, birds, reptile, insects
- no matter the category, animal are : flying, walking, swim or crawl.
- depending on the way they move, they have a maximum speed.
- there are animals that can swim and walk (Platypus)
- there are animals that can swim, fly and walk (Wild Duck)
- Not any animal that can fly is a bird, the bat is a mammal that flys, and not evey bird flys - the ostrich is a bird but doesn't fly*/

namespace oop_all_bogdanbirsa
{
    class Program
    {
        static void Main(string[] args)
        {
            Platypus platypus = new Platypus("Platypus");
            platypus.IWalk();
            platypus.ISwim();

            WildDuck wildDuck = new WildDuck("Wild Duck");
            wildDuck.IFly();
            wildDuck.ISwim();
            wildDuck.IWalk();

            Bat bat = new Bat("Bat");
            bat.IFly();

            Snake snake = new Snake("Snake");
            snake.ICrawl();
            snake.ISwim();

            Ant ant = new Ant("Ant");
            ant.IWalk();

            Ostrich ostrich = new Ostrich("Ostrich");
            ostrich.IWalk();
        }
    }
}
