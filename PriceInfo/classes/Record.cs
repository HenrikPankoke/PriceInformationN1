namespace PriceInfo.Classes
{
    public class Record
    {
        public DateTime HourUTC { get; set; }
        public DateTime HourDK { get; set; }
        public string PriceArea { get; set; }
        public double SpotPriceDKK { get; set; }
        public double SpotPriceEUR { get; set; }
    }
}
