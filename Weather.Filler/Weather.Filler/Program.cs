// See https://aka.ms/new-console-template for more information
using Weather.Database;
using Weather.Database.Models;
using Weather.Filler.Services;

Console.WriteLine("Updates weather data...");


var cities = new List<string>
            {
                "Rabat",
                "Madrid",
                "Paris",
                "Warsaw",
                "New York",
                "Krakow",
                "Tulum",
                "Dubai",
                "Prague",
                "London",
                "Berlin",
                "Amsterdam",
                "Ateny",
                "Moscow",
                "Oslo",
                "Rome",
                "Singapore",
                "Sofia",
                "Sydney",
                "Vienna",
                "Toronto",
                "Tokyo",
                "Lima",
                "Lizbona",
                "Jakarta",
                "Istanbul",
                "Geneva",
                "Dublin",
                "Frankfurt",
                "Chicago",
                "Cairo",
                "Copenhagen",
                "Reykjavik",
                "Seoul",
                "Shanghai",
                "Kair",
                "Neapol",
                "Tirana",
                "Minsk",
                "Brussels",
                "Zagreb",
                "Helsinki",
                "Monako",
                "Bern",
                "Ankara",
                "Belgrade",
                "Oslo",
                "Ljubljana",
                "Belgrade",
                "Bucarest",
            };


using (var context = new AppDbContext())
{
    WeatherDetailsService weatherService = new WeatherDetailsService();
    foreach (var cityName in cities)
    {
        var weather = await weatherService.GetWeather(cityName);

        var weatherDetails = context.Cities.FirstOrDefault(x => x.Name == cityName)?.Weather;

        if(weatherDetails == null)
        {
            weatherDetails = new WeatherDetails()
            {
                Temperature = (int)weather.Main.Temp - 273,
                Clouds = weather.Clouds.All,
                Pressure = weather.Main.Pressure,
                Wind = weather.Wind.Speed,
            };

            var city = new City()
            {
                Name = cityName,
                Weather = weatherDetails
            };

            context.Weathers.Add(weatherDetails);
            context.Cities.Add(city);
        }
        else
        {
            weatherDetails.Temperature = (int)weather.Main.Temp - 273;
            weatherDetails.Clouds = weather.Clouds.All;
            weatherDetails.Pressure = weather.Main.Pressure;
            weatherDetails.Wind = weather.Wind.Speed;
        }
        



       

        context.SaveChanges();
    }
}
