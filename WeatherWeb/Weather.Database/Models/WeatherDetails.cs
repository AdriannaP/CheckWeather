namespace Weather.Database.Models
{
    public class WeatherDetails
    {
        public int Id { get; set; }
        public int Temperature { get; set; }
        public long Clouds { get; set; }
        public double Wind { get; set; }
        public long Pressure { get; set; }
    }
}
