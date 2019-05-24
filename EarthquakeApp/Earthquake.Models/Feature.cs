using Newtonsoft.Json;

namespace EarthquakeApp.Earthquake.Models
{
    public class Feature
    {

        [JsonProperty("properties")]
        public Properties Properties { get; set; }
    }
}
