using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

            //display extra intfo
            sunriseOutput.Text = Form1.days[0].sunrise + " am";
            sunsetOutput.Text = Form1.days[0].sunset + " pm";
            feelsLikeTempOutput.Text = Form1.days[0].feelsLikeTemp + "°C";
            if(Form1.days[0].precipitation != null)
            {
                precipitationOutput.Text = Form1.days[0].precipitation;
            }
            else { precipitationOutput.Text = "0"; }
            windOutput.Text = Form1.days[0].windDirection + " " + Form1.days[0].windSpeed + " km/hr";
            visibilityOutput.Text = Form1.days[0].visibility;

            if(DateTime.Now.Hour > 19)
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
