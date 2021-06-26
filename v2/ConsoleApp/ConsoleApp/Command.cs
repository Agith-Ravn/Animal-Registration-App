using System;

namespace ConsoleApp
{
    public class Command
    {
        public static void AppInfo()
        {
            Console.WriteLine("1 = Registrer dyr \n2 = Slette dyr \n3 = Se liste av registrerte dyr");

            var command = Console.ReadLine();
            HandleCommand(command);
        }

        public void RegistrationInfo()
        {
            Console.WriteLine("For å legge til dyr, skriv inn dyreart og gruppe. Foreksempel \"Brown bear Pattedyr\"" +
                              "\n\nBruk en av disse gruppene:\n - Pattedyr \n - Reptiler \n - Amfibier \n - Fisk \n" +
                              " - Leddyr \n - Bløtdyr \n - Fugler.\n\nLegg til dyr:");
        }

        public static void HandleCommand(string command)
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
    }
}