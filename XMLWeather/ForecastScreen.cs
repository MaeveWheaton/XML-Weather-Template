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

            for (int i = 1; i < Form1.days.Count; i++)
            {
                date.Text = DateTime.Now.AddDays(i).ToString("dddd") + "\n";
                maxOutput.Text = Form1.days[i].tempHigh + "\n";
                minOutput.Text = Form1.days[i].tempLow + "\n";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
