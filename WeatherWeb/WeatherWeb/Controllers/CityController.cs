using Microsoft.AspNetCore.Mvc;
using WeatherWeb.Services;

namespace WeatherWeb.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        public IActionResult Cities()
        {
            return View(_cityService.GetCities());
        }

        public IActionResult City(int id)
        {
            return View(_cityService.GetCity(id));
        }

        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View(_cityService.GetCity(id));
        }
    }
}