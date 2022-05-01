using WeatherWeb.ViewModels;

namespace WeatherWeb.Services
{
    public interface ICityService
    {
        IList<CityViewModel> GetCities();
        CityViewModel GetCity(int id);
    }
}