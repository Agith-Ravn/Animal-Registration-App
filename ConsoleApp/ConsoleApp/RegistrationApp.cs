using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class RegistrationApp
    {
        private List<Mammals> Mammals{ get; set; }
        //private List<Animal> Reptiles { get; set; }
        //private List<Animal> Amphibians { get; set; }
        //private List<Animal> Fish { get; set; }
        //private List<Animal> Arthropods { get; set; }
        //private List<Animal> Mollusks { get; set; }
        //private List<Animal> Birds { get; set; }

        public RegistrationApp(params Mammals[] mammals)
        {
            Mammals = new List<Mammals>(mammals);
        }
        //public RegistrationApp(params Reptiles[] reptiles)
        //{
        //    Reptiles = new List<Reptiles>(reptiles);
        //}


        //private void AddAnimal(string species, string group)
        //{
        //    .Add(new Animal(species, group));
        //    Console.WriteLine($"Du har lagt til Species: {species}, Group: {group}");
        //}

        public string GetList()
        {
            for (int i = 0; i < Mammals.Count; i++)
            {
                Console.Write($"Speices: {Mammals[i].Species} | Group: {Mammals[i].Group} \n");
            }
        }

    }
}