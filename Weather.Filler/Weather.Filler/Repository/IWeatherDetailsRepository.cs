using Weather.Database.Models;

namespace Weather.Filler.Repository
{
    public interface IWeatherDetailsRepository
    {
        WeatherDetails Insert(WeatherDetails weather);
    }
}