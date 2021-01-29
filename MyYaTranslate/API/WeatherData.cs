using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MyYaTranslate.API
{
    class WeatherData
    {
        [JsonProperty("temp")]
        public string Temp { get; set; }

        [JsonProperty("feels_like")]
        public string FeelsLike { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("wind_speed")]
        public string WindSpeed { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("pressure_mm")]
        public string PressureMM { get; set; }
    }
}
