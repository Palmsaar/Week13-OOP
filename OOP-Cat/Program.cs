using System;

namespace OOP_Cat
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hungriness;
            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hungriness = 0;
                Console.WriteLine($"The cat {name} has been created");
            }
            public string Name
            {
                get { return name; }
            }
            public string Color
            {
                get { return color; }
            }
            public double Hungriness
            {
                get { return hungriness; }
            }
            public void ShowCatData()
            {
                Console.WriteLine($"name: {Name}");
                Console.WriteLine($"spots: {Color}");
                Console.WriteLine($"level of hungriness: {hungriness}");
            }
            public void CatMeow()
            {
                Console.WriteLine($"{Name} meows");
            }
            public void CatSleep()
            {
                Console.WriteLine($"{Name} is now sleeping");
                while (hungriness != 1)
                {
                    hungriness += 0.2;
                }
                CatMeow();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to name the cat?");
            string catName = Console.ReadLine();
            Console.WriteLine("What do you want the color of the cat to be?");
            string catColor = Console.ReadLine();

            Cat newCat = new Cat(catName, catColor);
            Console.WriteLine($"You can enter . any time to see the propertys of {newCat.Name}");
            int i = 0;
            while (i == 0)
            {
                Console.WriteLine($"Do you want {newCat.Name} to sleep? Y/N");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == ".")
                {
                    newCat.ShowCatData();
                }
                else
                {
                    if (userInput == "y")
                    {
                        newCat.CatSleep();
                    }
                    else if (userInput == "n")
                    {
                        i++;
                    }
                    else
                    {

                    }
                }
            } 


        }
    }
}