using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Weather.Contracts;

namespace Weather.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherData> GetWeatherDataAsync(string zipCode)
        {
            string apiKey = "<Your API Key Here>";
            var url = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={apiKey}&units=imperial";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<WeatherData>(json);

            return data;
        }
    }
}