using System;

namespace OOP_PartI
{
    class Program
    {
        class Dog
        {
            //class fields
            string name;
            int spots;
            double happiness;

            public Dog(string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The dog {name} has been created.");

            }
            //getters
            public string Name
            {
                get { return name; }
            }
            public int Spots
            {
                get { return spots; }
            }
            public double Happiness
            {
                get { return happiness; }
            }
            public void Barks()
            {
                Console.WriteLine("Woof-woof!");
                happiness += 0.2;
            }
            public void Wiggles()
            {
                Console.WriteLine($"{Name}:  Wiggle-wiggle");

            }
            public void Rename(string newName)
            {
                name = newName;
            }
            public void ShowDogData()
            {
                Console.WriteLine($"name: {Name}");
                Console.WriteLine($"spots: {Spots}");
                Console.WriteLine($"level of happiness: {Happiness}");
            }
        
        }
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Koer", 15);
            myDog.Barks();
            Console.WriteLine($"{myDog.Name}'s level of happiness: {myDog.Happiness}.");
            Dog myDog2 = new Dog("Alaska", 9);
            Console.WriteLine($"{myDog2.Name}'s level of happiness: {myDog2.Happiness}.");
            
            while (myDog.Happiness != 1)
            {
                myDog.Barks();
            }

            myDog.Wiggles();
            Console.WriteLine($"Enter a name to rename {myDog.Name}");
            myDog.Rename(Console.ReadLine());
            myDog.ShowDogData();

        }
    }
}
