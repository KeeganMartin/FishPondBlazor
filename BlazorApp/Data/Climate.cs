using System;

namespace BlazorApp.Data
{
    public class Climate
    {
        public DateTime Time { get; set; }
        public decimal AirTemp { get; set; }
        public decimal WaterTemp { get; set; }
        public decimal Humidity { get; set; }
        public decimal WaterDepth { get; set; }
    }
}
