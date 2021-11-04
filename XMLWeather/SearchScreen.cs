using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class SearchScreen : UserControl
    {
        public SearchScreen()
        {
            InitializeComponent();
            VisualsSetup();
        }

        /// <summary>
        /// Sets up visual aspects on screen
        /// </summary>
        private void VisualsSetup()
        {
            //set instruction text in text box
            locationInput.Text = "Search, ie. Stratford,CA";

            //clear error label
            errorLabel.Text = "";

            //set search picture box image
            searchPictureBox.BackgroundImage = new Icon(Properties.Resources.search1, new Size(32, 32)).ToBitmap();

            //change bg day/night, night from 8pm-6am
            Form1.ChooseBGImage(this);
        }

        private void todayLabel_Click(object sender, EventArgs e)
        {
            //switch to CurrentScreen
            ToCurrentScreen();
        }

        private void stratfordLabel_Click(object sender, EventArgs e)
        {
            //set location to Stratford, load data, switch screens
            Form1.location = "Stratford, CA";
            LoadData();
            ToCurrentScreen();
        }

        private void waterlooLabel_Click(object sender, EventArgs e)
        {
            //set location to Waterloo, load data, switch screens
            Form1.location = "Waterloo, CA";
            LoadData();
            ToCurrentScreen();
        }

        private void londonLabel_Click(object sender, EventArgs e)
        {
            //set location to London, load data, switch screens
            Form1.location = "London, CA";
            LoadData();
            ToCurrentScreen();
        }

        private void torontoLabel_Click(object sender, EventArgs e)
        {
            //set location to Toronto, load data, switch screens
            Form1.location = "Toronto, CA";
            LoadData();
            ToCurrentScreen();
        }

        private void searchPictureBox_Click(object sender, EventArgs e)
        {
            //search location when clicked
            SearchLocation();
        }

        private void locationInput_MouseClick(object sender, MouseEventArgs e)
        {
            //reset textbox when clicked
            locationInput.Text = "";
        }

        /// <summary>
        /// Clears days list data, extracts data for new location
        /// </summary>
        public void LoadData()
        {
            //Clear days list data, extract data for new location
            Form1.days.Clear();
            Form1.ExtractForecast();
            Form1.ExtractCurrent();
        }

        /// <summary>
        /// Changes to CurrentScreen
        /// </summary>
        public void ToCurrentScreen()
        {
            //change to current screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);

            cs.Focus();
        }

        /// <summary>
        /// Searches for entered location or display error message
        /// </summary>
        public void SearchLocation()
        {
            //if clicked but nothing entered
            if (locationInput.Text == "")
            {
                errorLabel.Text = "Error: Please enter a location";
            }

            //if location entered, try to load data, if not found display error
            try
            {
                Form1.location = locationInput.Text;
                LoadData();
                ToCurrentScreen();
            }
            catch
            {
                errorLabel.Text = "Error: Location not found";
            }
        }

        private void SearchScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //search when enter press, escape to exit
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SearchLocation();
                    break;
                case Keys.Escape:
                    Application.Exit();
                    break;
            }
        }
    }
}
