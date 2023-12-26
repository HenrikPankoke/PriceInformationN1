namespace PriceInfo.Classes
{
    
        public class ActualPrice
        {
            public ActualPrice(DateTime hourDK, double spotPriceDKK, double tarif)
            {
                HourDK = hourDK;
                SpotPriceDKK_kWh = spotPriceDKK;
                Tarif = tarif;
            }
            

            public DateTime HourDK { get; set; }

        public double SpotPriceDKK_kWh { get; set; }
        
        public double Tarif { get; set; }
        public double Total { get; set; }
        public double Duty { get; set; }
        public double VAT { get; set; }

        public string markingOre { get; set; }
        public string markingKr { get; set; }
        public string color { get; set; }
        public string columnText { get; set; }
    }
    

}