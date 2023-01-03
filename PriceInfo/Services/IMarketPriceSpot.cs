using PriceInfo.Classes;


namespace PriceInfo.Services
{
    public interface IMarketPriceSpot
    {
        public SpotPrice GetSpotPrice();
    }
}
