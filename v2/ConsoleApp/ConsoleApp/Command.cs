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
            Console.WriteLine("For å legge til dyr, skriv inn dyreart og nr på gruppe. Foreksempel \"Brown bear - 1\" \nHusk bindestrek!" +
                              "\n\n 1 = Amphibians \n 2 = Arthropods \n 3 = Birds \n 4 = Fish \n" +
                              " 5 = Mammals \n 6 = Mollusks \n 7 = Reptiles.\n");
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
                    string[] c = command2.Split("-");
                    c[0] = c[0].Replace("-", " ");
                    var index = Convert.ToInt32(c[1].Trim()) - 1;

                    if (c[1].Trim() == "1") c[1] = "Amphibians";
                    else if (c[1].Trim() == "2") c[1] = "Arthropods";
                    else if (c[1].Trim() == "3") c[1] = "Birds";
                    else if (c[1].Trim() == "4") c[1] = "Fish";
                    else if (c[1].Trim() == "5") c[1] = "Mammals";
                    else if (c[1].Trim() == "6") c[1] = "Mollusks";
                    else if (c[1].Trim() == "7") c[1] = "Reptiles";

                    App.AddAnimal(c[0].TrimEnd(), c[1], index);
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
                Console.WriteLine("\nSkriv Gruppe og nr på dyr som skal slettes. Eksempel: \"Mammals - 1\"");
                var command2 = Console.ReadLine();

                string[] c = command2.Split("-");

                if (ValidGroup(c[0].Replace("-"," ").Trim()) && Convert.ToInt32(c[1]) > 0)
                {
                    App.DeleteAnimal(c[0].Trim(), Convert.ToInt32(c[1]) - 1);
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

        private bool ValidGroup(string group)
        {
            if (group == "Amphibians" || group == "Arthropods" || group == "Birds" ||
                group == "Fish" || group == "Mammals" || group == "Mollusks" ||
                group == "Reptiles")
            {
                return true;
            }

            else
            {
                return false;
            }

        }
    }
}