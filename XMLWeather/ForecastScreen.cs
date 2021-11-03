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
    public partial class ForecastScreen : UserControl
    {
        
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            List<PictureBox> iconBoxes = new List<PictureBox>() { date1Icon, date2Icon, date3Icon, date4Icon, date5Icon, date6Icon };

            date.Text = "";
            maxOutput.Text = "";
            minOutput.Text = "";
            for (int i = 1; i < Form1.days.Count; i++)
            {
                date.Text += DateTime.Now.AddDays(i).ToString("dddd") + "\n\n\n";
                maxOutput.Text += Form1.days[i].tempHigh + "\n\n\n";
                minOutput.Text += Form1.days[i].tempLow + "\n\n\n";

                int symbol = Convert.ToInt32(Form1.days[i].symbol);
                if (symbol > 800)
                {
                    iconBoxes[i-1].BackgroundImage = new Icon(Properties.Resources.sun_lightcloud, new Size(32, 32)).ToBitmap();
                }
                else if (symbol == 800)
                {
                    iconBoxes[i-1].BackgroundImage = new Icon(Properties.Resources.sun, new Size(32, 32)).ToBitmap();
                }
                else if(symbol > 600)
                {
                    iconBoxes[i-1].BackgroundImage = new Icon(Properties.Resources.sun_lightcloud_snow, new Size(32, 32)).ToBitmap();
                }
                else if (symbol > 500)
                {
                    iconBoxes[i-1].BackgroundImage = new Icon(Properties.Resources.sun_lightcloud_grain, new Size(32, 32)).ToBitmap();
                }
                else if (symbol > 300)
                {
                    iconBoxes[i-1].BackgroundImage = new Icon(Properties.Resources.sun_lightcloud_rain, new Size(32, 32)).ToBitmap();
                }
                else if (symbol > 200)
                {
                    iconBoxes[i-1].BackgroundImage = new Icon(Properties.Resources.sun_littlecloud_flash_rain, new Size(32, 32)).ToBitmap();
                }
                else
                {
                    iconBoxes[i-1].BackgroundImage = new Icon(Properties.Resources.error, new Size(32, 32)).ToBitmap();
                }
            }

            if (DateTime.Now.Hour > 19)
            {
                this.BackgroundImage = Properties.Resources.nightbg3;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.sunbg3;
            }
        }

        private void todayLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
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
