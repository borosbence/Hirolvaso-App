namespace Hirolvaso.Models
{
    public class Valuta
    {
        public string Currency { get; set; }
        public string Rate { get; set; }
        public string Updown { get; set; }
        public string Symbol
        {
            get
            {
                switch (Updown)
                {
                    case "UP":
                        return "🔺";
                    case "DN":
                        return "🔻";
                    default:
                        return "=";
                }
            }
        }
    }
}
