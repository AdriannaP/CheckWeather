using WeatherWeb.Repositories;
using WeatherWeb.ViewModels;

namespace WeatherWeb.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public IList<CityViewModel> GetCities()
        {
            var cities = _cityRepository.GetCities();
            var cityViewModels = new List<CityViewModel>();

            foreach(var city in cities)
            {
                var viewModel = new CityViewModel()
                {
                    Name = city.Name,
                    Id = city.Id
                };

                cityViewModels.Add(viewModel);
            }

            return cityViewModels;
        }

        public CityViewModel GetCity(int id)
        {
            var city = _cityRepository.GetCity(id);
            var viewModel = new CityViewModel()
            {
                Name = city.Name,
                Weather = city.Weather
            };

            return viewModel;
        }
    }
}
