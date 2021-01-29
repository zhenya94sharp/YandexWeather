using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyYaTranslate.API
{
    public class ApiWorker
    {
        private FormMain form;

        public static Task<string> GetWeather(FormMain form)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;

                webClient.Headers.Add("X-Yandex-API-Key", "60d11bc1-cbad-4959-82d1-779a7d1710d2");

                string url = $"https://api.weather.yandex.ru/v2/forecast?lat={form.labelLat.Text}&lon={form.labelLon.Text}&lang=ru_RU&extra=true";

                return Task<string>.Factory.StartNew(() => webClient.DownloadString(url));

           
        }

        public static Task<string> GetCoord(FormMain form)
        {
            WebClient webClient = new WebClient();

            webClient.Encoding = Encoding.UTF8;

                string url = $" https://geocode-maps.yandex.ru/1.x/?format=json&apikey=935672c0-a148-4cb9-9f8f-bb20e00ab9a7&geocode={form.textBoxCity.Text}&results=1";

                return Task<string>.Factory.StartNew(() => webClient.DownloadString(url));

        }

    }

}
