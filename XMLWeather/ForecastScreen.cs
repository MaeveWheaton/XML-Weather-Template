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
        //create list of picture boxes to fill later
        List<PictureBox> iconBoxes = new List<PictureBox>();

        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        /// <summary>
        /// Outputs min, max, and symbol for each date, sets bg
        /// </summary>
        public void displayForecast()
        {
            //add picture boxes to list
            iconBoxes = new List<PictureBox>() { date1Icon, date2Icon, date3Icon, date4Icon, date5Icon, date6Icon };

            //clear labels
            date.Text = maxOutput.Text = minOutput.Text = 
                nextDayDateOutput.Text = nextDayMaxOutput.Text = nextDayMinOutput.Text = "";

            //set next day data
            nextDayDateOutput.Text = DateTime.Now.AddDays(1).ToString("dddd");
            nextDayMaxOutput.Text = Form1.days[1].tempHigh;
            nextDayMinOutput.Text = Form1.days[1].tempLow;
            SetIcon(Convert.ToInt32(Form1.days[1].symbol), 1, 48);

            //output min, max, and symbol for each date after
            for (int i = 2; i < Form1.days.Count; i++)
            {
                //output min and max for each date
                date.Text += DateTime.Now.AddDays(i).ToString("dddd") + "\n\n\n";
                maxOutput.Text += Form1.days[i].tempHigh + "\n\n\n";
                minOutput.Text += Form1.days[i].tempLow + "\n\n\n";

                //set symbol according to weather symbol value
                int symbol = Convert.ToInt32(Form1.days[i].symbol);
                SetIcon(symbol, i, 32);
            }

            //change bg day/night, night from 8pm-6am
            Form1.ChooseBGImage(this);
        }

        /// <summary>
        /// Sets icon according to symbol value
        /// </summary>
        /// <param name="symbol">value</param>
        /// <param name="i">list index</param>
        public void SetIcon(int symbol, int i, int size)
        {
            if (symbol > 800)
            {
                iconBoxes[i - 1].BackgroundImage = new Icon(Properties.Resources.sun_lightcloud, new Size(size, size)).ToBitmap();
            }
            else if (symbol == 800)
            {
                iconBoxes[i - 1].BackgroundImage = new Icon(Properties.Resources.sun, new Size(size, size)).ToBitmap();
            }
            else if (symbol > 600)
            {
                iconBoxes[i - 1].BackgroundImage = new Icon(Properties.Resources.sun_lightcloud_snow, new Size(size, size)).ToBitmap();
            }
            else if (symbol > 500)
            {
                iconBoxes[i - 1].BackgroundImage = new Icon(Properties.Resources.sun_lightcloud_grain, new Size(size, size)).ToBitmap();
            }
            else if (symbol > 300)
            {
                iconBoxes[i - 1].BackgroundImage = new Icon(Properties.Resources.sun_lightcloud_rain, new Size(size, size)).ToBitmap();
            }
            else if (symbol > 200)
            {
                iconBoxes[i - 1].BackgroundImage = new Icon(Properties.Resources.sun_littlecloud_flash_rain, new Size(size, size)).ToBitmap();
            }
            else
            {
                iconBoxes[i - 1].BackgroundImage = new Icon(Properties.Resources.error, new Size(size, size)).ToBitmap();
            }
        }

        private void todayLabel_Click(object sender, EventArgs e)
        {
            //switch to current screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);

            cs.Focus();
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            //switch to search screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen ss = new SearchScreen();
            f.Controls.Add(ss);

            ss.Focus();
        }

        private void ForecastScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //press escape to exit
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Application.Exit();
                    break;
            }
        }
    }
}
