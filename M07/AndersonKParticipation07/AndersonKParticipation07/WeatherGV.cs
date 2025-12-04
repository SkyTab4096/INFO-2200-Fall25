using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonKParticipation07
{
    /// <summary>
    /// Defines the WeatherGV class to store the contents of the api call
    /// </summary>
    public static class WeatherGV
    {
        public static string CityName { get; set; }
        public static double CurTemp { get; set; }
        public static double MinTemp { get; set; }
        public static double MaxTemp { get; set; }
    }
}
