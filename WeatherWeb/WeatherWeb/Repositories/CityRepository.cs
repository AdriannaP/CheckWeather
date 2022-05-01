using System.Data.Entity;
using Weather.Database;
using Weather.Database.Models;

namespace WeatherWeb.Repositories
{
    public class CityRepository : ICityRepository
    {
        private AppDbContext _appDbContext;

        public CityRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IList<City> GetCities()
        {
            return _appDbContext.Cities.ToList();
        }

        public City GetCity(int id)
        {
            return _appDbContext.Cities
                .Where(c => c.Id == id)
                .Include(c => c.Weather)
                .FirstOrDefault();
        }
    }
}
