using Newtonsoft.Json;

namespace Weather.Contracts
{
    public class WeatherData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("main")]
        public MainData Main { get; set; }
    }

    public class MainData
    {
        [JsonProperty("temp")]
        public decimal Temperature { get; set; }

        [JsonProperty("feels_like")]
        public decimal FeelsLike { get; set; }

        [JsonProperty("humidity")]
        public decimal Humidity { get; set; }
    }
}

