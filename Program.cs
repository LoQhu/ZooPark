using System;
using System.Collections.Generic;

namespace ZooPark
{
    class Program
    {
        delegate List<IAnimal> ZooBuisness();
        static void Main(string[] args)
        {
            ZooBuisness doBizz = FillZoo;
            var zooAnimals = doBizz();

            foreach(Animals x in zooAnimals)
            {
                x.Speak();
                x.Eat();
                x.Sleep();
                Console.WriteLine("_____________________________________");
            }

            #region Printsruff
            //land1.Eat();
            //land1.Speak();
            //land1.Walk();
            //land1.Sleep();
            //Console.WriteLine("__________________________________________________");

            //land2.Eat();
            //land2.Speak();
            //land2.Walk();
            //land2.Sleep();
            //Console.WriteLine("__________________________________________________");
            //sea1.Eat();
            //sea1.Speak();
            //sea1.Swim();
            //sea1.Sleep();
            //Console.WriteLine("__________________________________________________");
            //sea2.Eat();
            //sea2.Speak();
            //sea2.Swim();
            //sea2.Sleep();
            //Console.WriteLine("__________________________________________________");
            //air1.Eat();
            //air1.Speak();
            //air1.Fly();
            //air1.Sleep();
            //Console.WriteLine("__________________________________________________");
            //air2.Eat();
            //air2.Speak();
            //air2.Fly();
            //air2.Sleep();
            #endregion

        }

        static List<IAnimal> FillZoo()
        {
            List<IAnimal> li = new();

            li.Add(new LandAnimal("Jaguar", "Rooaaar", "Red raw meat", 10, 4));
            li.Add(new LandAnimal("Kiwi", "Pip Pip", "Really small seeds", 4, 2));

            li.Add(new SeaAnimal("Orca", "Whoooaah", "Penguins,seals,fish oh my", 5, 2));
            li.Add(new SeaAnimal("Salmon", "Blop Blop", "High grade fish flakes", 2, 2));

            li.Add(new AirAnimal("Raven", "Hello", "Nuts and small mammals", 6, 2));
            li.Add(new AirAnimal("Dragonfly", "Buzzz", "Leafs", 0, 4));

            return li;
        }
        
    }
}
