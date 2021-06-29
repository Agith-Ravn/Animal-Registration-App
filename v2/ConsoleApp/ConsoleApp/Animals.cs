using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Animals
    {
        //Inneholder alle grupper
        //0 - amphibiansList
        //1 - arthropodsList
        //2 - birdsList
        //3 - fishList
        //4 - mammalsList
        //5 - mollusksList
        //6 - reptilesList
        private AnimalGroup[] AllAnimalGroupsList { get; set; }

        public Animals(params AnimalGroup[] animalGroups)
        {
            AllAnimalGroupsList = animalGroups;
        }

        public void GetAllAnimalDescription()
        {
            Console.Clear();
            foreach (var animalGroups in AllAnimalGroupsList)
            {
                animalGroups.GetAllAnimalDescription();
            }
        }

        public void AddAnimal(string species, string group, int index)
        {
            AllAnimalGroupsList[index].AddAnimal(species, group);
        }

        public void DeleteAnimal(string group, int index)
        {
            int groupIndex = getGroupIndex(group);
            AllAnimalGroupsList[groupIndex].DeleteAnimal(index);

        }

        public int getGroupIndex(string group)
        {
            int index = 0;
            if (group == "Amphibians") index = 0;
            else if (group == "Arthropods") index = 1;
            else if (group == "Birds") index = 2;
            else if (group == "Fish") index = 3;
            else if (group == "Mammals") index = 4;
            else if (group == "Mollusks") index = 5;
            else if (group == "Reptiles") index = 6;
            return index;
        }
    }
}