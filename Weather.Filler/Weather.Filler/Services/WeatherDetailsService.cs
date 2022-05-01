using Newtonsoft.Json;

namespace Weather.Filler.Services
{
    public class WeatherDetailsService
    {
        public async Task<WeatherObject> GetWeather(string city)
        {
            APICaller aPICaller = new APICaller();
            string json = await aPICaller.GetWeatherFromOpenWeatherAsync(city);
            return JsonConvert.DeserializeObject<WeatherObject>(json);
        }
    }
}
