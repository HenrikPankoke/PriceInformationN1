namespace PriceInfo.Classes
{
    
        public class TarifWindow
        {
            public TarifWindow(int startHourDK, int endHourDK, string priceArea, double tarifDKK)
            {
                StartHourDK = startHourDK;
                EndHourDK = endHourDK;
                PriceArea = priceArea;
                TarifDKK = tarifDKK;
            }

            public int StartHourDK { get; set; }
            public int EndHourDK { get; set; }
            public string PriceArea { get; set; }
            public double TarifDKK { get; set; }
        }
    

}