using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        //create list to hold day objects
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //create a day object
                Day day = new Day();

                //fill day object with required data
                reader.ReadToFollowing("time");
                day.date = reader.GetAttribute("day");

                //get precipitation probability
                reader.ReadToFollowing("precipitation");
                day.precipitation = reader.GetAttribute("probability");

                //get low and high and remove decimals
                reader.ReadToFollowing("temperature");
                day.tempLow = Convert.ToDouble(reader.GetAttribute("min")).ToString("0");
                day.tempHigh = Convert.ToDouble(reader.GetAttribute("max")).ToString("0");

                //if information for the date was found add to the days list
                if (day.date != null)
                {
                    days.Add(day);
                }
            }
        }

        private void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("country");
            days[0].country = reader.ReadElementContentAsString();

            reader.ReadToFollowing("sun");
            days[0].sunrise = reader.GetAttribute("rise").Remove(0,11);
            days[0].sunset = reader.GetAttribute("set").Remove(0, 11);
            days[0].sunrise = days[0].sunrise.Remove(5, 3);
            days[0].sunset = days[0].sunset.Remove(5, 3);

            reader.ReadToFollowing("temperature");
            //get temp and round
            days[0].currentTemp = Convert.ToDouble(reader.GetAttribute("value")).ToString("0");

            reader.ReadToFollowing("feels_like");
            days[0].feelsLikeTemp = Convert.ToDouble(reader.GetAttribute("value")).ToString("0");

            reader.ReadToFollowing("speed");
            days[0].windSpeed = reader.GetAttribute("value");

            reader.ReadToFollowing("direction");
            days[0].windDirection = reader.GetAttribute("code");

            reader.ReadToFollowing("visibility");
            days[0].visibility = reader.GetAttribute("value");

            //find weather condition and att to appropriate item in days list
            reader.ReadToFollowing("weather");
            days[0].condition = reader.GetAttribute("number");
        }


    }
}
