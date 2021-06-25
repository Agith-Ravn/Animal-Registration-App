using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Del opp i disse gruppene:
             *
             *  - Mammals    |  Pattedyr
             *  - Reptiles   |  Reptiler
             *  - Amphibians |  Amfibier
             *  - Fish       |  Fisk
             *  - Arthropods |  Leddyr
             *  - Mollusks   |  Bløtdyr 
             *  - Birds      |  Fugler
             */

            var app = new RegistrationApp(
                new Mammals("Human", "Mammals"),
                new Mammals("Dog", "Mammals"));


                //new Animal("Tarantula", "Arthropods"),
                //new Animal("Dragonfly", "Arthropods"),
                //new Animal("Raven", "Bird"),
                //new Animal("Tiger shark", "Fish"),
                //new Animal("Clownfish", "Fish"),
                //new Animal("Coconut octopus", "Mollusks"),
                //new Animal("Tomato frog", "Amphibians"),
                //new Animal("Sinai Agama", "Reptiles"),
                //new Animal("Crocodile", "Reptiles")
                //);

            var x = false;
            while (x == false)
            {
                var command = new Command(app);
                command.AppInfo();
                //Console.WriteLine(app.AppInfo());
                //var command = Console.ReadLine();
                //app.HandleCommand(command);

            }

        }
    }
}
