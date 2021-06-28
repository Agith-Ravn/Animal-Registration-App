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
                    string[] x = command2.Split("-");
                    x[0] = x[0].Replace("-", " ");

                    if (x[1] == " 1") x[1] = "Amphibians";
                    else if (x[1] == " 2") x[1] = "Arthropods";
                    else if (x[1] == " 3") x[1] = "Birds";
                    else if (x[1] == " 4") x[1] = "Fish";
                    else if (x[1] == " 5") x[1] = "Mammals";
                    else if (x[1] == " 6") x[1] = "Mollusks";
                    else if (x[1] == " 7") x[1] = "Reptiles";

                    App.AddAnimal(x[0].TrimEnd(), x[1]);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ugyldig kommando.. prøv igjen.");
                }
            }

        //    else if (command == "2")
        //    {
        //        App.GetAllAnimalDescription();
        //        Console.WriteLine("\nSkriv nr på dyr som skal slettes");
        //        var command2 = Convert.ToInt32(Console.ReadLine());

        //        if (command2 > 1 && command2 < App.Animals.Count + 1)
        //        {
        //            App.DeleteAnimal(Convert.ToInt32(command2) - 1);
        //        }
        //        else
        //        {
        //            WrongFormat();
        //        }
        //        AppInfo();
        //    }

            else if (command == "3")
            {
                App.GetAllAnimalDescription();
                TilbakeTilAppInfo();
            }

        //    else
        //    {
        //        WrongFormat();
        //    }

        }
    }
}