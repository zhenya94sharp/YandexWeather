﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyYaTranslate.API
{
   class ApiHelper
    {
        public static Dictionary<string, string> WeatherConditions { get; } = new Dictionary<string, string>()
        {
            {"clear", "ясно"},
            {"partly-cloudy", "малооблачно"},
            {"cloudy","облачно с прояснениями"},
            {"overcast","пасмурно"},
            {"drizzle","морось"},
            {"light-rain","небольшой дождь"},
            {"rain","дождь"},
            {"moderate-rain","умеренно сильный дождь"},
            {"heavy-rain","сильный дождь"},
            {"continuous-heavy-rai","длительный сильный дождь"},
            {"showers","ливень"},
            {"wet-snow","дождь со снегом"},
            {"light-snow","небольшой снег"},
            {"snow","снег"},
            {"snow-showers","снегопад" },
            {"hail","град" },
            {"thunderstorm","гроза" },
            {"thunderstorm-with-rain","дождь с грозой" },
            {"thunderstorm-with-hail","гроза с градом" }
        };

        public static Dictionary<string, string> WeatherWindDir { get; } = new Dictionary<string, string>()
        {
            {"nw","северо-западное" },
            {"n","северное" },
            {"ne","северо-восточное" },
            {"e","восточное" },
            {"se","юго-восточное" },
            {"s","южное" },
            {"sw","юго-западное" },
            {"w","западное" },
            {"c","штиль" }
        };
    }
}
