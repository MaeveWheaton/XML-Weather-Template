/*
 * Maeve Wheaton
 * Mr. T
 * November 3, 2021
 * Weather app, defaults to current weather data in Stratford, CA. Clicking 7 Day brings up a forcast for the next 6 days with icons.
 * Clicking Search brings up a page where the user can search for a different city, when chosen it goes back to the current data using weather data for the new city.
 * On either of the other pages, Today can be clicked to return to the current data page.
*/

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

        //variable to hold city
        public static string location = "Stratford,CA";

        public Form1()
        {
            InitializeComponent();

            //get weather data
            ExtractForecast();
            ExtractCurrent();
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public static void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=" + location + "&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //create a day object
                Day day = new Day();

                //fill day object with required data
                reader.ReadToFollowing("time");
                day.date = reader.GetAttribute("day");

                //get weather symbol number
                reader.ReadToFollowing("symbol");
                day.symbol = reader.GetAttribute("number");

                //get precipitation probability, amount, and type
                reader.ReadToFollowing("precipitation");
                day.precipProb = reader.GetAttribute("probability");
                day.precipAmount = reader.GetAttribute("value");
                day.precipType = reader.GetAttribute("type");

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

        public static void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=" + location + "&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //get city and country and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");
            reader.ReadToFollowing("country");
            days[0].country = reader.ReadElementContentAsString();

            //get sunrise and sunsest, remove extra data before time
            reader.ReadToFollowing("sun");
            days[0].sunrise = reader.GetAttribute("rise").Remove(0,11);
            days[0].sunset = reader.GetAttribute("set").Remove(0, 11);
            days[0].sunrise = days[0].sunrise.Remove(5, 3);
            days[0].sunset = days[0].sunset.Remove(5, 3);

            //get temp and round
            reader.ReadToFollowing("temperature");
            days[0].currentTemp = Convert.ToDouble(reader.GetAttribute("value")).ToString("0");

            reader.ReadToFollowing("feels_like");
            days[0].feelsLikeTemp = Convert.ToDouble(reader.GetAttribute("value")).ToString("0");

            //get humidity
            reader.ReadToFollowing("humidity");
            days[0].humidity = reader.GetAttribute("value");

            //get wind speed and convert m/s to km/h
            reader.ReadToFollowing("speed");
            days[0].windSpeed = (Convert.ToDouble(reader.GetAttribute("value")) * 3.6).ToString("0");

            //get wind direction
            reader.ReadToFollowing("direction");
            days[0].windDirection = reader.GetAttribute("code");

            //get visibility index
            reader.ReadToFollowing("visibility");
            days[0].visibility = reader.GetAttribute("value");

            //get weather condition
            reader.ReadToFollowing("weather");
            days[0].condition = reader.GetAttribute("value");
        }


    }
}
