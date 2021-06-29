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


        public void AddAnimal(string species, string group, int index)
        {
            Animals.AddAnimal(species, group, index);
        }

        public void GetAllAnimalDescription()
        {
            Animals.GetAllAnimalDescription();
        }

        public void DeleteAnimal(string group, int index)
        {
            Animals.DeleteAnimal(group, index);
        }
    }
}