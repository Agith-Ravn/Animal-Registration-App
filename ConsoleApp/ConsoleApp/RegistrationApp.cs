using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class RegistrationApp
    {
        public List<Animal> Animals { get; set; }

        public RegistrationApp(params Animal[] animals)
        {
            Animals = new List<Animal>(animals);
        }

        public string AppInfo()
        {
            return "1 = Registrer dyr \n2 = Slette dyr \n3 = Se liste av registrerte dyr";
        }

        public string RegistrationInfo()
        {
            return "For å legge til dyr, skriv inn dyreart og gruppe. Foreksempel \"Brown bear Pattedyr\"" +
                   "\n\nBruk en av disse gruppene:\n - Pattedyr \n - Reptiler \n - Amfibier \n - Fisk \n" +
                   " - Leddyr \n - Fisk \n - Bløtdyr \n - Fugler.\n\nLegg til dyr:";
        }

        public void HandleCommand(string command)
        {
            if (command == "1")
            {
                Console.Clear();
                Console.WriteLine(RegistrationInfo());
                var command2 = Console.ReadLine();

                //DEL OPP DENNE.. Blir for langt
                if (command2.Contains(" "))
                {
                    string[] x = command2.Split(" ");
                    string species = x[0];
                    string group = x[1];
                    AddAnimal(species, group);
                }
            }

            /*
             * 2 og 3
             *
             *
             */

        }

        private void AddAnimal(string species, string group)
        {
            Animals.Add(new Animal(species, group));
            Console.WriteLine($"Du har lagt til Species: {species}, Group: {group}");
        }
    }
}