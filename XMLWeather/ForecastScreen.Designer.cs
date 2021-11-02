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
            this.label3 = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(276, 132);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(220, 67);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "7 Day";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(555, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 71);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // maxOutput
            // 
            this.maxOutput.AutoSize = true;
            this.maxOutput.ForeColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(190, 348);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(68, 32);
            this.maxOutput.TabIndex = 44;
            this.maxOutput.Text = "Max";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(218, 166);
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
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(47, 348);
            this.date.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(75, 32);
            this.date.TabIndex = 64;
            this.date.Text = "Date";
            // 
            // minOutput
            // 
            this.minOutput.AutoSize = true;
            this.minOutput.ForeColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(359, 348);
            this.minOutput.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(61, 32);
            this.minOutput.TabIndex = 65;
            this.minOutput.Text = "Min";
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.date);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(762, 1072);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label minOutput;
    }
}
