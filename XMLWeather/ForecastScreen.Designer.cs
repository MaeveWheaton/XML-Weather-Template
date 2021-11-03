namespace XMLWeather
{
    partial class ForecastScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.forecastLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.date6Icon = new System.Windows.Forms.PictureBox();
            this.date5Icon = new System.Windows.Forms.PictureBox();
            this.date4Icon = new System.Windows.Forms.PictureBox();
            this.date3Icon = new System.Windows.Forms.PictureBox();
            this.date2Icon = new System.Windows.Forms.PictureBox();
            this.date1Icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.date6Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date5Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date4Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date3Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date1Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(274, 133);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(220, 67);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "6 Day";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.White;
            this.todayLabel.Location = new System.Drawing.Point(555, 10);
            this.todayLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(200, 71);
            this.todayLabel.TabIndex = 61;
            this.todayLabel.Text = "Today";
            this.todayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.todayLabel.Click += new System.EventHandler(this.todayLabel_Click);
            // 
            // maxOutput
            // 
            this.maxOutput.AutoSize = true;
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.ForeColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(298, 319);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(68, 32);
            this.maxOutput.TabIndex = 44;
            this.maxOutput.Text = "Max";
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(231, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 64);
            this.label5.TabIndex = 63;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(109, 319);
            this.date.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(75, 32);
            this.date.TabIndex = 64;
            this.date.Text = "Date";
            // 
            // minOutput
            // 
            this.minOutput.AutoSize = true;
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.ForeColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(421, 319);
            this.minOutput.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(61, 32);
            this.minOutput.TabIndex = 65;
            this.minOutput.Text = "Min";
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(7, 10);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(204, 71);
            this.searchLabel.TabIndex = 66;
            this.searchLabel.Text = "Search";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // date6Icon
            // 
            this.date6Icon.BackColor = System.Drawing.Color.Transparent;
            this.date6Icon.Location = new System.Drawing.Point(536, 762);
            this.date6Icon.Name = "date6Icon";
            this.date6Icon.Size = new System.Drawing.Size(80, 80);
            this.date6Icon.TabIndex = 72;
            this.date6Icon.TabStop = false;
            // 
            // date5Icon
            // 
            this.date5Icon.BackColor = System.Drawing.Color.Transparent;
            this.date5Icon.Location = new System.Drawing.Point(536, 666);
            this.date5Icon.Name = "date5Icon";
            this.date5Icon.Size = new System.Drawing.Size(80, 80);
            this.date5Icon.TabIndex = 71;
            this.date5Icon.TabStop = false;
            // 
            // date4Icon
            // 
            this.date4Icon.BackColor = System.Drawing.Color.Transparent;
            this.date4Icon.Location = new System.Drawing.Point(536, 571);
            this.date4Icon.Name = "date4Icon";
            this.date4Icon.Size = new System.Drawing.Size(80, 80);
            this.date4Icon.TabIndex = 70;
            this.date4Icon.TabStop = false;
            // 
            // date3Icon
            // 
            this.date3Icon.BackColor = System.Drawing.Color.Transparent;
            this.date3Icon.Location = new System.Drawing.Point(536, 476);
            this.date3Icon.Name = "date3Icon";
            this.date3Icon.Size = new System.Drawing.Size(80, 80);
            this.date3Icon.TabIndex = 69;
            this.date3Icon.TabStop = false;
            // 
            // date2Icon
            // 
            this.date2Icon.BackColor = System.Drawing.Color.Transparent;
            this.date2Icon.Location = new System.Drawing.Point(536, 381);
            this.date2Icon.Name = "date2Icon";
            this.date2Icon.Size = new System.Drawing.Size(80, 80);
            this.date2Icon.TabIndex = 68;
            this.date2Icon.TabStop = false;
            // 
            // date1Icon
            // 
            this.date1Icon.BackColor = System.Drawing.Color.Transparent;
            this.date1Icon.Location = new System.Drawing.Point(536, 288);
            this.date1Icon.Name = "date1Icon";
            this.date1Icon.Size = new System.Drawing.Size(80, 80);
            this.date1Icon.TabIndex = 67;
            this.date1Icon.TabStop = false;
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.date6Icon);
            this.Controls.Add(this.date5Icon);
            this.Controls.Add(this.date4Icon);
            this.Controls.Add(this.date3Icon);
            this.Controls.Add(this.date2Icon);
            this.Controls.Add(this.date1Icon);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.date);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(762, 1072);
            ((System.ComponentModel.ISupportInitialize)(this.date6Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date5Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date4Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date3Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date1Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.PictureBox date1Icon;
        private System.Windows.Forms.PictureBox date2Icon;
        private System.Windows.Forms.PictureBox date3Icon;
        private System.Windows.Forms.PictureBox date4Icon;
        private System.Windows.Forms.PictureBox date5Icon;
        private System.Windows.Forms.PictureBox date6Icon;
    }
}
