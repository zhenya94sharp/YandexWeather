using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MyYaTranslate.API
{
    class CoordData
    {
        [JsonProperty("pos")]
        public string Pos { get; set; }

    }
}
