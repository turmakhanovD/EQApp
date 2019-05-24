using Newtonsoft.Json;

namespace EarthquakeApp.Earthquake.Models
{
    public class Properties
    {

        [JsonProperty("mag")]
        public double Magnitude { get; set; }

        [JsonProperty("place")]
        public string Place { get; set; }


        [JsonProperty("sig")]
        public int SeismicWaves { get; set; }

        [JsonProperty("magType")]
        public string MagnitudeType { get; set; }

    }
}