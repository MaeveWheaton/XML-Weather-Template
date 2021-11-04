
namespace XMLWeather
{
    partial class SearchScreen
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
            this.todayLabel = new System.Windows.Forms.Label();
            this.locationInput = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.stratfordLabel = new System.Windows.Forms.Label();
            this.waterlooLabel = new System.Windows.Forms.Label();
            this.londonLabel = new System.Windows.Forms.Label();
            this.torontoLabel = new System.Windows.Forms.Label();
            this.searchPictureBox = new System.Windows.Forms.PictureBox();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.todayLabel.TabIndex = 67;
            this.todayLabel.Text = "Today";
            this.todayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.todayLabel.Click += new System.EventHandler(this.todayLabel_Click);
            // 
            // locationInput
            // 
            this.locationInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationInput.Location = new System.Drawing.Point(67, 288);
            this.locationInput.Name = "locationInput";
            this.locationInput.Size = new System.Drawing.Size(575, 53);
            this.locationInput.TabIndex = 68;
            this.locationInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.locationInput_MouseClick);
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(7, 479);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(748, 67);
            this.searchLabel.TabIndex = 69;
            this.searchLabel.Text = "Suggested Locations";
            // 
            // stratfordLabel
            // 
            this.stratfordLabel.BackColor = System.Drawing.Color.Transparent;
            this.stratfordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stratfordLabel.ForeColor = System.Drawing.Color.White;
            this.stratfordLabel.Location = new System.Drawing.Point(10, 556);
            this.stratfordLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.stratfordLabel.Name = "stratfordLabel";
            this.stratfordLabel.Size = new System.Drawing.Size(191, 51);
            this.stratfordLabel.TabIndex = 70;
            this.stratfordLabel.Text = "Stratford";
            this.stratfordLabel.Click += new System.EventHandler(this.stratfordLabel_Click);
            // 
            // waterlooLabel
            // 
            this.waterlooLabel.BackColor = System.Drawing.Color.Transparent;
            this.waterlooLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterlooLabel.ForeColor = System.Drawing.Color.White;
            this.waterlooLabel.Location = new System.Drawing.Point(10, 619);
            this.waterlooLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.waterlooLabel.Name = "waterlooLabel";
            this.waterlooLabel.Size = new System.Drawing.Size(191, 51);
            this.waterlooLabel.TabIndex = 71;
            this.waterlooLabel.Text = "Waterloo";
            this.waterlooLabel.Click += new System.EventHandler(this.waterlooLabel_Click);
            // 
            // londonLabel
            // 
            this.londonLabel.BackColor = System.Drawing.Color.Transparent;
            this.londonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.londonLabel.ForeColor = System.Drawing.Color.White;
            this.londonLabel.Location = new System.Drawing.Point(10, 684);
            this.londonLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.londonLabel.Name = "londonLabel";
            this.londonLabel.Size = new System.Drawing.Size(191, 51);
            this.londonLabel.TabIndex = 72;
            this.londonLabel.Text = "London";
            this.londonLabel.Click += new System.EventHandler(this.londonLabel_Click);
            // 
            // torontoLabel
            // 
            this.torontoLabel.BackColor = System.Drawing.Color.Transparent;
            this.torontoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.torontoLabel.ForeColor = System.Drawing.Color.White;
            this.torontoLabel.Location = new System.Drawing.Point(10, 749);
            this.torontoLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.torontoLabel.Name = "torontoLabel";
            this.torontoLabel.Size = new System.Drawing.Size(191, 51);
            this.torontoLabel.TabIndex = 73;
            this.torontoLabel.Text = "Toronto";
            this.torontoLabel.Click += new System.EventHandler(this.torontoLabel_Click);
            // 
            // searchPictureBox
            // 
            this.searchPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.searchPictureBox.Location = new System.Drawing.Point(648, 279);
            this.searchPictureBox.Name = "searchPictureBox";
            this.searchPictureBox.Size = new System.Drawing.Size(80, 76);
            this.searchPictureBox.TabIndex = 74;
            this.searchPictureBox.TabStop = false;
            this.searchPictureBox.Click += new System.EventHandler(this.searchPictureBox_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(60, 364);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(582, 73);
            this.errorLabel.TabIndex = 75;
            this.errorLabel.Text = "errorMessage";
            // 
            // SearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.searchPictureBox);
            this.Controls.Add(this.torontoLabel);
            this.Controls.Add(this.londonLabel);
            this.Controls.Add(this.waterlooLabel);
            this.Controls.Add(this.stratfordLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.locationInput);
            this.Controls.Add(this.todayLabel);
            this.Name = "SearchScreen";
            this.Size = new System.Drawing.Size(762, 1072);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SearchScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.TextBox locationInput;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label stratfordLabel;
        private System.Windows.Forms.Label waterlooLabel;
        private System.Windows.Forms.Label londonLabel;
        private System.Windows.Forms.Label torontoLabel;
        private System.Windows.Forms.PictureBox searchPictureBox;
        private System.Windows.Forms.Label errorLabel;
    }
}
