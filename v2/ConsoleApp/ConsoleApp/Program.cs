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

            var amphibiansList = new AnimalGroup(
                new Animal("Tomato frog", "Amphibians"));

            var arthropodsList = new AnimalGroup(
                new Animal("Tarantula", "Arthropods"),
                new Animal("Dragonfly", "Arthropods"));

            var mammalsList = new AnimalGroup(
                new Animal("Human", "Mammals"),
                new Animal("Dog", "Mammals"));

            var birdsList = new AnimalGroup(
                new Animal("Raven", "Bird"));

            var fishList = new AnimalGroup(
                new Animal("Tiger shark", "Fish"),
                new Animal("Clownfish", "Fish"));

            var mollusksList = new AnimalGroup(
                new Animal("Coconut octopus", "Mollusks"));

            var reptilesList = new AnimalGroup(
                new Animal("Sinai Agama", "Reptiles"),
                new Animal("Crocodile", "Reptiles"));

            var animals = new Animals(amphibiansList, arthropodsList,
                birdsList, fishList, mammalsList, mollusksList, reptilesList);

            var app = new RegistrationApp(animals);

            var x = false;
            while (x == false)
            {
                var command = new Command(app);
                command.AppInfo();

            }

        }
    }
}
