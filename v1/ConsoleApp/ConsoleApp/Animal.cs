using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Animal
    {
        public string Species { get; set; }
        public string Group { get; set; }

        public Animal(string species, string group)
        {
            Species = species;
            Group = group;
        }

        public string GetAnimalDescription()
        {
            return $"Species: {Species} | Group: {Group}";
        }
    }
}