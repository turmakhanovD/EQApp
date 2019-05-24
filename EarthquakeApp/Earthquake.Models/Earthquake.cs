using Newtonsoft.Json;
using System.Collections.Generic;

namespace EarthquakeApp.Earthquake.Models
{
    public class Earthquake
    {
        [JsonProperty("features")]
        public IList<Feature> Features { get; set; }
    }
}
