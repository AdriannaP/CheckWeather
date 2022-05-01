using Weather.Database.Models;

namespace Weather.Filler.Repository
{
    public interface ICityRepository
    {
        City Insert(City city);
    }
}