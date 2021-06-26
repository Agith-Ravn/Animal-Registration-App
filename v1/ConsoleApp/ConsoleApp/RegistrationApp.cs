using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class RegistrationApp
    {
        public List<Animal> Animals { get; set; }

        public RegistrationApp(params Animal[] mammals)
        {
            Animals = new List<Animal>(mammals);
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
            for (int i = 0; i < Animals.Count; i++)
            {
                Console.Write($"{i + 1}. Group: {Animals[i].Group} - Speices: {Animals[i].Species} \n");
            }
        }

        public void DeleteAnimal(int index)
        {
            Animals.RemoveAt(index);
            Console.Clear();
            Console.WriteLine($"Slettet \n");
        }

    }
}