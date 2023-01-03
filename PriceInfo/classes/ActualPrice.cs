namespace PriceInfo.Classes
{
    
        public class ActualPrice
        {
            public ActualPrice(DateTime hourDK, double spotPriceDKK, double tarif)
            {
                HourDK = hourDK;
                SpotPriceDKK = spotPriceDKK;
                Tarif = tarif;
            }
            

            public DateTime HourDK { get; set; }

        public double SpotPriceDKK { get; set; }
        //public double SpotPriceDKK { get { return SpotPriceDKK / 10; } set { } }
        public double Tarif { get; set; }
        //public double Total { get; set; }
        public double Total { get { return (SpotPriceDKK+Tarif)*1.25; } set { } }
    }
    

}