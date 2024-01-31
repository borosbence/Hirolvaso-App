namespace Hirolvaso.Models
{
    public class Arfolyam
    {
        public DateOnly Date { get; set; }
        public Dictionary<string, double> Rates { get; set; }
    }
}
