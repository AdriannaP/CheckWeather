using Weather.Database.Models;

namespace WeatherWeb.ViewModels
{
    public class CityViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public WeatherDetails Weather { get; set; }
    }
}
