namespace Hirolvaso.Models
{
    public partial class Idojaras
    {
        public Location Location { get; set; }
        public Current Current { get; set; }
    }

    public class Condition
    {
        public string Icon { get; set; }
    }

    public class Location
    {
        public string Name { get; set; }
    }

    public partial class Current
    {
        public string Last_Updated { get; set; }
        public double Temp_C { get; set; }
        public Condition Condition { get; set; }
        public double Wind_Kph { get; set; }
        public int Humidity { get; set; }
    }
}
