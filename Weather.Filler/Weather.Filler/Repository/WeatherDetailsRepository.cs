using Weather.Database;
using Weather.Database.Models;

namespace Weather.Filler.Repository
{
    public class WeatherDetailsRepository : IWeatherDetailsRepository
    {
        private readonly AppDbContext _appDbContext;

        public WeatherDetailsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public WeatherDetails Insert(WeatherDetails weather)
        {
            return _appDbContext.Weathers.Add(weather);
        }
    }
}
