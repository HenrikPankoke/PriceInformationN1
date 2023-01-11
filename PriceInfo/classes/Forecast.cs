using Newtonsoft.Json;

namespace PriceInfo.Classes
{

    public class Forecast
    {
        [JsonProperty("Forecast created")]
        public DateTime Forecastcreated { get; set; }
        public List<DK1> DK1 { get; set; }
        public List<DK2> DK2 { get; set; }
    }
    public class DK1
    {
        public DateTime Time { get; set; }
        public double Price { get; set; }
        public string marking { get; set; }
        public string color { get; set; }
        public string columnText { get; set; }
    }

    public class DK2
    {
        public DateTime Time { get; set; }
        public double Price { get; set; }
        public string marking { get; set; }
        public string color { get; set; }
        public string columnText { get; set; }
    }


}