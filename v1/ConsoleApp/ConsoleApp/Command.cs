using System;

namespace ConsoleApp
{
    public class Command
    {
        private RegistrationApp App { get; set; }

        public Command(RegistrationApp app)
        {
            App = app;
        }

        public void AppInfo()
        {
            Console.WriteLine("1 = Registrer dyr \n2 = Slette dyr \n3 = Se liste av registrerte dyr \n");
            Console.Write("Skriv kommando: ");
            var command = Console.ReadLine();
            HandleCommand(command);
        }

        public void RegistrationInfo()
        {
            Console.WriteLine("For å legge til dyr, skriv inn dyreart og gruppe. Foreksempel \"Brown bear - Mammals\" \nHusk bindestrek!" +
                              "\n\nBruk en av disse gruppene:\n - Mammals \n - Reptiles \n - Amphibians \n - Fish \n" +
                              " - Arthropods \n - Mollusks \n - Birds.\n");
            Console.Write("Legg til dyr: ");
        }

        public void TilbakeTilAppInfo()
        {
            Console.WriteLine("Trykk på en Enter for å gå tilbake");
            Console.ReadLine();
            Console.Clear();
            AppInfo();
        }

        public void WrongFormat()
        {
            Console.Clear();
            Console.WriteLine("Ugyldig kommando.. prøv igjen. \n");
        }

        public void HandleCommand(string command)
        {
            if (command == "1")
            {
                Console.Clear();
                RegistrationInfo();
                var command2 = Console.ReadLine();

                if (command2.Contains("-"))
                {
                    string[] x = command2.Split("-");
                    x[0] = x[0].Replace("-", " ");
                    App.AddAnimal(x[0].TrimEnd(), x[1].Trim());
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ugyldig kommando.. prøv igjen.");
                }
            }

            else if (command == "2")
            {
                App.GetAllAnimalDescription();
                Console.WriteLine("\nSkriv nr på dyr som skal slettes");
                var command2 = Convert.ToInt32(Console.ReadLine());

                if (command2 > 1 && command2 < App.Animals.Count + 1)
                {
                    App.DeleteAnimal(Convert.ToInt32(command2) - 1);
                }
                else
                {
                    WrongFormat();
                }
                AppInfo();
            }

            else if (command == "3")
            {
                App.GetAllAnimalDescription();
                TilbakeTilAppInfo();
            }

            else
            {
                WrongFormat();
            }

        }
    }
}