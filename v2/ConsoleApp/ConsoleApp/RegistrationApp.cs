using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class RegistrationApp
    {
        private Animals Animals { get; set; }

        public RegistrationApp(Animals animals)
        {
            Animals = animals;
        }


        public void AddAnimal(string species, string group)
        {

            Animals.Add(new Animal(species, group));
            Console.Clear();
            Console.WriteLine($"Du har lagt til Species: {species} - Group: {group} \n");
        }

        public void GetAllAnimalDescription()
        {
            Console.Clear();
            Animals.GetAllAnimalDescription();
        }

        //public void DeleteAnimal(int index)
        //{
        //    Animals.RemoveAt(index);
        //    Console.Clear();
        //    Console.WriteLine($"Slettet \n");
        //}


    }
}