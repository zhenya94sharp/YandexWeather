using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyYaTranslate.API;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Svg;

namespace MyYaTranslate
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private async void buttonGetWeather_Click(object sender, EventArgs e)
        {
            if (textBoxCity.Text == "")
            {
                MessageBox.Show("Ошибка! Введите город");
                return;
            }

            string dataCoordFromYa = await ApiWorker.GetCoord(this);

            JObject jsonDataCoord = JObject.Parse(dataCoordFromYa);

            CoordData coord = JsonConvert.DeserializeObject<CoordData>(jsonDataCoord["response"]["GeoObjectCollection"]["featureMember"][0]["GeoObject"]["Point"].ToString());

            string[] coordArray = coord.Pos.Split(new char[] { ' ' });

            labelLon.Text = coordArray[0];
            labelLat.Text = coordArray[1];


            string dataWeatherFromYa = await ApiWorker.GetWeather(this);

            JObject jsonDataWeather = JObject.Parse(dataWeatherFromYa);

            WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(jsonDataWeather["fact"].ToString());

            WebClient webClient = new WebClient();

            webClient.Encoding = Encoding.UTF8;

            webClient.DownloadFile($"https://yastatic.net/weather/i/icons/blueye/color/svg/{weatherData.Icon}.svg", "icon.svg");

            labelTemp.Text = weatherData.Temp;
            labelFeelsLike.Text = weatherData.FeelsLike;

            SvgDocument svg = SvgDocument.Open("icon.svg");
            pictureIcon.Image = svg.Draw();

            labelCondition.Text = ApiHelper.WeatherConditions[weatherData.Condition];

            labelWindSpeed.Text = weatherData.WindSpeed;

            labelWindDir.Text = ApiHelper.WeatherWindDir[weatherData.WindDir];

            labelPressureMM.Text = weatherData.PressureMM;
        }

    }
}

