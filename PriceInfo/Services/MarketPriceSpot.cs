using Newtonsoft.Json;
using PriceInfo.Classes;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace PriceInfo.Services
{
    public class MarketPriceSpot
    {
        public SpotPrice spotPrice { get; set; }
        public MarketPriceSpot()
        {
            
            using (var client = new HttpClient())
            {

                //https://api.energidataservice.dk/dataset/Elspotprices?start=2022-12-31&end=2023-01-01&filter={%22PriceArea%22:[%22DK1%22]}
                string today = DateTime.Today.ToString("yyyy-MM-dd");
                string tomorrow = DateTime.Today.AddDays(2).ToString("yyyy-MM-dd");
                StringBuilder sb = new StringBuilder();
                sb.Append("https://api.energidataservice.dk/dataset/Elspotprices?start=");
                sb.Append(today);
                sb.Append("&end=");
                sb.Append(tomorrow);
                sb.Append("&filter={%22PriceArea%22:[%22DK1%22]}");
                var endpoint = new Uri(sb.ToString());
                endpoint = new Uri("https://api.energidataservice.dk/dataset/Elspotprices?start=2022-12-31&end=2023-01-01&filter={%22PriceArea%22:[%22DK1%22]}");




                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    spotPrice = JsonConvert.DeserializeObject<SpotPrice>(json);
                }
            }
        }
        
    }



        
    
}
