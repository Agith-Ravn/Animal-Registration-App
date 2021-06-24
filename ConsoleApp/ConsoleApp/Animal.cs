namespace ConsoleApp
{
    public class Animal
    {
        private string Species { get; set; }
        private string Group { get; set; }

        public Animal(string species, string group)
        {
            Species = species;
            Group = group;
        }

        public string GetDescription()
        {
            return $"Species: {Species} | Group: {Group}";
        }
    }
}