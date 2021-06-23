namespace ConsoleApp
{
    public class DyreGruppe
    {
        private string Gruppe { get; set; }
        private string Dyr { get; set; }

        public DyreGruppe(string gruppe, string dyr)
        {
            Gruppe = gruppe;
            Dyr = dyr;
        }
    }
}