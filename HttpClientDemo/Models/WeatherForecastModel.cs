using System;

namespace HttpClientDemo.Models
{

    public class WeatherForecastModel
    {
        public DayForecastModel[] consolidated_weather { get; set; }
        public DateTime sun_rise { get; set; }
        public DateTime sun_set { get; set; }
        public string title { get; set; }
        public string timezone { get; set; }
    }

    public class DayForecastModel
    {
        public string weather_state_name { get; set; }
        public string applicable_date { get; set; }
        public float min_temp { get; set; }
        public float max_temp { get; set; }
    }


}
