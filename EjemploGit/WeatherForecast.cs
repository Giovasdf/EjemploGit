using System;

namespace EjemploGit
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 321232 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
