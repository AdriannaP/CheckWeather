using RestSharp;

namespace Weather.Filler
{
    public class APICaller
    {
        public async Task<string> GetWeatherFromOpenWeatherAsync(string city)
        {
            var client = new RestClient("https://api.openweathermap.org/data/2.5/");
            var request = new RestRequest("weather/", Method.Get);
            request.AddParameter("q", city);
            request.AddParameter("appid", "c1f104f4288f2d8004ccd15a6eb5c2f2");

            var response = await client.ExecuteGetAsync(request);
            if (!response.IsSuccessful)
            {
                throw new Exception($"Unable to get weather for {city}");
            }

            return response.Content;
        }
    }
}
