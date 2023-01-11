namespace PriceInfo.Classes
{
    
        public class Prices
        {
            public SpotPrice spotPrice { get; set; }
            public List<TarifWindow> tarifs { get; set; }
            public List<ActualPrice> calculatedActualPrices { get; set; }

            public Forecast forCast { get; set; }
            public List<EstimatedPrice> calculatedForeCastPrices { get; set; }
        }
    
}
