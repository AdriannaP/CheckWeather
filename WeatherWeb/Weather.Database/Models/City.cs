using System.ComponentModel.DataAnnotations.Schema;

namespace Weather.Database.Models
{
    public class City
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        
        public int WeatherDetailsId { get; set; }
        [ForeignKey("WeatherDetailsId")]
        public virtual WeatherDetails Weather { get; set; }
    }
}
