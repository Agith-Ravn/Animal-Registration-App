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
            foreach (var animalGroups in AllAnimalGroupsList)
            {
                animalGroups.GetAllAnimalDescription();
            }
        }

        public void Add(Animal animal)
        {
            AllAnimalGroupsList[0].Add(animal);
        }
    }
}