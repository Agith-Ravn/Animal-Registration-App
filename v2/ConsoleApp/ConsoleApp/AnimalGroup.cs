using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class AnimalGroup
    {
        //Inneholder alle dyr
        private List<Animal> AnimalGroupList { get; set; }

        public AnimalGroup(params Animal[] animals)
        {
            AnimalGroupList = new List<Animal>(animals);
        }

        public void GetAllAnimalDescription()
        {
            for (int i = 0; i < AnimalGroupList.Count; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("- " + AnimalGroupList[i].GetGroupDescription() + " -");
                }
                Console.Write($"{i + 1}. ");
                Console.WriteLine(AnimalGroupList[i].GetSpeciesDescription());
            }
            Console.Write("\n");
        }

        public void AddAnimal(string species, string group)
        {
            AnimalGroupList.Add(new Animal(species, group));
            Console.Clear();
            Console.WriteLine($"Du har lagt til Species: {species} - Group: {group} \n");
        }

        public void DeleteAnimal(int index)
        {
            AnimalGroupList.RemoveAt(index);
            Console.Clear();
            Console.WriteLine($"Slettet \n");
        }
    }
}