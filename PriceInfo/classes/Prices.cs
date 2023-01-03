namespace PriceInfo.Classes
{
    
        public class Prices
        {
            public SpotPrice spotPrice { get; set; }
            public List<TarifWindow> tarifs { get; set; }
            public List<ActualPrice> calculatedPrices { get; set; }
        }
    
}
