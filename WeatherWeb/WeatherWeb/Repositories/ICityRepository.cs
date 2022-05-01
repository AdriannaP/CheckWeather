using Weather.Database.Models;

namespace WeatherWeb.Repositories
{
    public interface ICityRepository
    {
        IList<City> GetCities();
        City GetCity(int id);
    }
}