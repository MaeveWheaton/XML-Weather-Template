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
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            //display important details
            dateOutput.Text = DateTime.Now.ToString("dddd, MMMM dd");
            cityOutput.Text = Form1.days[0].location + ", "+ Form1.days[0].country;
            currentTempOutput.Text = Form1.days[0].currentTemp + "°C";
            lowOutput.Text = Form1.days[0].tempLow + "°C";
            highOutput.Text = Form1.days[0].tempHigh + "°C";

            // Creates a TextInfo based on the "en-US" culture.
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            //Format condition to have uppercases and display
            conditionOutput.Text = myTI.ToTitleCase(Form1.days[0].condition);

            //display extra intfo
            sunriseOutput.Text = Form1.days[0].sunrise + " am";
            sunsetOutput.Text = Form1.days[0].sunset + " pm";
            humidityOutput.Text = Form1.days[0].humidity + " %";
            feelsLikeTempOutput.Text = Form1.days[0].feelsLikeTemp + "°C";
            windOutput.Text = Form1.days[0].windDirection + " " + Form1.days[0].windSpeed + " km/hr";
            visibilityOutput.Text = Form1.days[0].visibility;

            //if type not null, display type of precip, else just precip
            if (Form1.days[0].precipType != null)
            {
                chanceOfLabel.Text = "Chance of " + Form1.days[0].precipType;
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

            //change bg day/night, night from 8pm-6am
            if (DateTime.Now.Hour > 19 || DateTime.Now.Hour < 6)
            {
                this.BackgroundImage = Properties.Resources.nightbg3;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.sunbg3;
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen cs = new SearchScreen();
            f.Controls.Add(cs);
        }
    }
}
