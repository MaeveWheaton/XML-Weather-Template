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
            //display important details
            dateOutput.Text = DateTime.Now.ToString("dddd, MMMM dd");
            cityOutput.Text = Form1.days[0].location + ", " + Form1.days[0].country;
            currentTempOutput.Text = Form1.days[0].currentTemp + "°C";
            lowOutput.Text = Form1.days[0].tempLow + "°C";
            highOutput.Text = Form1.days[0].tempHigh + "°C";

            //format condition to have uppercases and display
            conditionOutput.Text = myTI.ToTitleCase(Form1.days[0].condition);

            //display extra intfo
            sunriseOutput.Text = Form1.days[0].sunrise; //times are wrong, need to be converted to timezone
            sunsetOutput.Text = Form1.days[0].sunset;
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

            //set last updated 
            lastUpdatedOutput.Text = Form1.days[0].lastUpdated.Remove(10, 9) + "  " + Form1.days[0].lastUpdated.Remove(1, 11).Remove(5, 3);
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
    }
}
