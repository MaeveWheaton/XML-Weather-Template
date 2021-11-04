using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        // Creates a TextInfo based on the "en-US" culture.
        TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

        //refresh timer counter
        int timerCounter = 0;

        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        /// <summary>
        /// Displays outputs and bg
        /// </summary>
        public void DisplayCurrent()
        {
            //set text outputs
            SetTextOutputs();
            
            //change bg day/night, night from 8pm-6am
            Form1.ChooseBGImage(this);
        }

        /// <summary>
        /// Sets all text outputs
        /// </summary>
        public void SetTextOutputs()
        {
            //display date, city, current temp, low and high
            dateOutput.Text = DateTime.Now.ToString("dddd, MMMM dd");
            cityOutput.Text = Form1.days[0].location + ", " + Form1.days[0].country;
            currentTempOutput.Text = Form1.days[0].currentTemp + "°C";
            lowOutput.Text = Form1.days[0].tempLow + "°C";
            highOutput.Text = Form1.days[0].tempHigh + "°C";

            //format condition to have uppercases and display
            conditionOutput.Text = myTI.ToTitleCase(Form1.days[0].condition);

            //get sunrise and sunset, convert to timezone and display
            DateTime sunriseTime = TimeZoneConversion(Convert.ToDateTime(Form1.days[0].sunrise), -4);
            sunriseOutput.Text = sunriseTime.ToString("hh:mm tt");
            DateTime sunsetTime = TimeZoneConversion(Convert.ToDateTime(Form1.days[0].sunset), -4);
            sunsetOutput.Text = sunsetTime.ToString("hh:mm tt");

            //display humidity percent, feels like temp, wind direction & speed, and visibility
            humidityOutput.Text = Form1.days[0].humidity + " %";
            feelsLikeTempOutput.Text = Form1.days[0].feelsLikeTemp + "°C";
            windOutput.Text = Form1.days[0].windDirection + " " + Form1.days[0].windSpeed + " km/hr";
            visibilityOutput.Text = Form1.days[0].visibility;

            //if type not null, display type of precip, else just precip
            if (Form1.days[0].precipType != null)
            {
                chanceOfLabel.Text = "Chance of " + myTI.ToTitleCase(Form1.days[0].precipType);
            }
            else
            {
                chanceOfLabel.Text = "Chance of Precipitation";
            }
            //display percent chance
            chanceOutput.Text = (Convert.ToDouble(Form1.days[0].precipProb) * 100).ToString() + " %";

            //display precip amount if any, else 0
            if (Form1.days[0].precipAmount != null)
            {
                precipitationOutput.Text = (Convert.ToDouble(Form1.days[0].precipAmount) * 100).ToString() + " cm";
            }
            else
            {
                precipitationOutput.Text = "0 cm";
            }

            //get last updated time, convert to timezone and display
            DateTime lastUpdateTime = TimeZoneConversion(Convert.ToDateTime(Form1.days[0].lastUpdated), -4);
            lastUpdatedOutput.Text = lastUpdateTime.ToString("dd/MM/yyy  hh:mm tt");
        }

        /// <summary>
        /// Converts time zones
        /// </summary>
        /// <param name="time">time to convert</param>
        /// <param name="conversion">hour change</param>
        /// <returns></returns>
        public DateTime TimeZoneConversion(DateTime time, int conversion)
        {
            //get hour
            int hour = time.Hour;

            //add 20 hrs and remove day if adding conversion will make it negative
            if (hour + conversion < 0)
            {
                time = time.AddHours(24 + conversion);
                time = time.AddDays(-1);
            }
            else //else add conversion hrs
            {
                time = time.AddHours(conversion);
            }

            return time;
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            //switch to forecast screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            //switch to search screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen cs = new SearchScreen();
            f.Controls.Add(cs);
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            //increase timer
            timerCounter++;

            //if 10 mins have passed, refresh data
            if (timerCounter == 6000)
            {
                Form1.days.Clear();
                Form1.ExtractForecast();
                Form1.ExtractCurrent();

                timerCounter = 0;
            }
        }
    }
}
