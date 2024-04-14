namespace PriceInfo.Classes
{
    public class SpotPrice
    {
        public int total { get; set; }
        public string filters { get; set; }
        public string dataset { get; set; }
        public List<ElPrisSpot> records { get; set; }
    }


}
