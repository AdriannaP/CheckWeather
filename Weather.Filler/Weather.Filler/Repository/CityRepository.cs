using Weather.Database;
using Weather.Database.Models;

namespace Weather.Filler.Repository
{
    public class CityRepository : ICityRepository
    {
        private readonly AppDbContext _appDbContext;

        public CityRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public City Insert(City city)
        {
            return _appDbContext.Cities.Add(city);
        }
    }
}
