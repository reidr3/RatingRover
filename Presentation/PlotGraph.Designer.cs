namespace RatingRover.Presentation
{
    partial class PlotGraph
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.minYearBar = new System.Windows.Forms.TrackBar();
            this.minRatingBar = new System.Windows.Forms.TrackBar();
            this.maxYearBar = new System.Windows.Forms.TrackBar();
            this.maxRatingBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoutLabel = new System.Windows.Forms.LinkLabel();
            this.SeperatorBevel2 = new System.Windows.Forms.Label();
            this.SeperatorBevel1 = new System.Windows.Forms.Label();
            this.WatchListLabel = new System.Windows.Forms.LinkLabel();
            this.manageCollectionLabel = new System.Windows.Forms.LinkLabel();
            this.SearchLabel = new System.Windows.Forms.LinkLabel();
            this.SearchFormTitleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaxYear = new System.Windows.Forms.Label();
            this.lblMinYear = new System.Windows.Forms.Label();
            this.lblMaxRat = new System.Windows.Forms.Label();
            this.lblMinRat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minYearBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRatingBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxYearBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRatingBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart1.Location = new System.Drawing.Point(138, 170);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(580, 374);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.MouseLeave += new System.EventHandler(this.chart1_MouseLeave);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // minYearBar
            // 
            this.minYearBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minYearBar.LargeChange = 10;
            this.minYearBar.Location = new System.Drawing.Point(138, 566);
            this.minYearBar.Maximum = 2015;
            this.minYearBar.Minimum = 1903;
            this.minYearBar.Name = "minYearBar";
            this.minYearBar.Size = new System.Drawing.Size(580, 45);
            this.minYearBar.TabIndex = 1;
            this.minYearBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.minYearBar.Value = 1903;
            this.minYearBar.Scroll += new System.EventHandler(this.minYearBar_Scroll);
            // 
            // minRatingBar
            // 
            this.minRatingBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.minRatingBar.LargeChange = 1;
            this.minRatingBar.Location = new System.Drawing.Point(46, 186);
            this.minRatingBar.Name = "minRatingBar";
            this.minRatingBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.minRatingBar.Size = new System.Drawing.Size(45, 374);
            this.minRatingBar.TabIndex = 2;
            this.minRatingBar.Scroll += new System.EventHandler(this.minRatingBar_Scroll);
            this.minRatingBar.Leave += new System.EventHandler(this.minRatingBar_Leave);
            // 
            // maxYearBar
            // 
            this.maxYearBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxYearBar.LargeChange = 10;
            this.maxYearBar.Location = new System.Drawing.Point(138, 119);
            this.maxYearBar.Maximum = 2015;
            this.maxYearBar.Minimum = 1903;
            this.maxYearBar.Name = "maxYearBar";
            this.maxYearBar.Size = new System.Drawing.Size(580, 45);
            this.maxYearBar.TabIndex = 3;
            this.maxYearBar.Value = 2015;
            this.maxYearBar.Scroll += new System.EventHandler(this.maxYearBar_Scroll);
            // 
            // maxRatingBar
            // 
            this.maxRatingBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxRatingBar.LargeChange = 1;
            this.maxRatingBar.Location = new System.Drawing.Point(775, 170);
            this.maxRatingBar.Name = "maxRatingBar";
            this.maxRatingBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.maxRatingBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maxRatingBar.Size = new System.Drawing.Size(45, 374);
            this.maxRatingBar.TabIndex = 4;
            this.maxRatingBar.Tag = "";
            this.maxRatingBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.maxRatingBar.Value = 10;
            this.maxRatingBar.Scroll += new System.EventHandler(this.maxRatingBar_Scroll);
            this.maxRatingBar.Leave += new System.EventHandler(this.maxRatingBar_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(9, 13);
            this.label7.TabIndex = 93;
            this.label7.Text = "|";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RatingRover.Properties.Resources.test;
            this.pictureBox1.Location = new System.Drawing.Point(34, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(28, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 90;
            this.label1.Text = "Plot Graph";
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.Location = new System.Drawing.Point(808, 60);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(40, 13);
            this.LogoutLabel.TabIndex = 88;
            this.LogoutLabel.TabStop = true;
            this.LogoutLabel.Text = "Logout";
            this.LogoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLabel_LinkClicked);
            // 
            // SeperatorBevel2
            // 
            this.SeperatorBevel2.AutoSize = true;
            this.SeperatorBevel2.Location = new System.Drawing.Point(266, 53);
            this.SeperatorBevel2.Name = "SeperatorBevel2";
            this.SeperatorBevel2.Size = new System.Drawing.Size(9, 13);
            this.SeperatorBevel2.TabIndex = 87;
            this.SeperatorBevel2.Text = "|";
            // 
            // SeperatorBevel1
            // 
            this.SeperatorBevel1.AutoSize = true;
            this.SeperatorBevel1.Location = new System.Drawing.Point(150, 53);
            this.SeperatorBevel1.Name = "SeperatorBevel1";
            this.SeperatorBevel1.Size = new System.Drawing.Size(9, 13);
            this.SeperatorBevel1.TabIndex = 86;
            this.SeperatorBevel1.Text = "|";
            // 
            // WatchListLabel
            // 
            this.WatchListLabel.AutoSize = true;
            this.WatchListLabel.Location = new System.Drawing.Point(281, 53);
            this.WatchListLabel.Name = "WatchListLabel";
            this.WatchListLabel.Size = new System.Drawing.Size(55, 13);
            this.WatchListLabel.TabIndex = 85;
            this.WatchListLabel.TabStop = true;
            this.WatchListLabel.Text = "WatchList";
            this.WatchListLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WatchListLabel_LinkClicked_1);
            // 
            // manageCollectionLabel
            // 
            this.manageCollectionLabel.AutoSize = true;
            this.manageCollectionLabel.Location = new System.Drawing.Point(165, 53);
            this.manageCollectionLabel.Name = "manageCollectionLabel";
            this.manageCollectionLabel.Size = new System.Drawing.Size(95, 13);
            this.manageCollectionLabel.TabIndex = 84;
            this.manageCollectionLabel.TabStop = true;
            this.manageCollectionLabel.Text = "Manage Collection";
            this.manageCollectionLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.manageCollectionLabel_LinkClicked_1);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.SearchLabel.LinkColor = System.Drawing.Color.Blue;
            this.SearchLabel.Location = new System.Drawing.Point(103, 53);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(41, 13);
            this.SearchLabel.TabIndex = 83;
            this.SearchLabel.TabStop = true;
            this.SearchLabel.Text = "Search";
            this.SearchLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SearchLabel_LinkClicked);
            // 
            // SearchFormTitleLabel
            // 
            this.SearchFormTitleLabel.AutoSize = true;
            this.SearchFormTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SearchFormTitleLabel.Location = new System.Drawing.Point(97, 18);
            this.SearchFormTitleLabel.Name = "SearchFormTitleLabel";
            this.SearchFormTitleLabel.Size = new System.Drawing.Size(252, 31);
            this.SearchFormTitleLabel.TabIndex = 82;
            this.SearchFormTitleLabel.Text = "Movie Rating Rover";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "Plot Graph";
            // 
            // lblMaxYear
            // 
            this.lblMaxYear.AutoSize = true;
            this.lblMaxYear.Location = new System.Drawing.Point(379, 151);
            this.lblMaxYear.Name = "lblMaxYear";
            this.lblMaxYear.Size = new System.Drawing.Size(79, 13);
            this.lblMaxYear.TabIndex = 95;
            this.lblMaxYear.Text = "Maximum Year:";
            // 
            // lblMinYear
            // 
            this.lblMinYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinYear.AutoSize = true;
            this.lblMinYear.Location = new System.Drawing.Point(379, 547);
            this.lblMinYear.Name = "lblMinYear";
            this.lblMinYear.Size = new System.Drawing.Size(76, 13);
            this.lblMinYear.TabIndex = 96;
            this.lblMinYear.Text = "Minimum Year:";
            // 
            // lblMaxRat
            // 
            this.lblMaxRat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxRat.AutoSize = true;
            this.lblMaxRat.Location = new System.Drawing.Point(724, 348);
            this.lblMaxRat.Name = "lblMaxRat";
            this.lblMaxRat.Size = new System.Drawing.Size(56, 13);
            this.lblMaxRat.TabIndex = 97;
            this.lblMaxRat.Text = "Max Rate:";
            // 
            // lblMinRat
            // 
            this.lblMinRat.AutoSize = true;
            this.lblMinRat.Location = new System.Drawing.Point(82, 348);
            this.lblMinRat.Name = "lblMinRat";
            this.lblMinRat.Size = new System.Drawing.Size(53, 13);
            this.lblMinRat.TabIndex = 98;
            this.lblMinRat.Text = "Min Rate:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(838, 2);
            this.label3.TabIndex = 99;
            // 
            // PlotGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(864, 621);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMinRat);
            this.Controls.Add(this.lblMaxRat);
            this.Controls.Add(this.lblMinYear);
            this.Controls.Add(this.lblMaxYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoutLabel);
            this.Controls.Add(this.SeperatorBevel2);
            this.Controls.Add(this.SeperatorBevel1);
            this.Controls.Add(this.WatchListLabel);
            this.Controls.Add(this.manageCollectionLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchFormTitleLabel);
            this.Controls.Add(this.maxRatingBar);
            this.Controls.Add(this.maxYearBar);
            this.Controls.Add(this.minRatingBar);
            this.Controls.Add(this.minYearBar);
            this.Controls.Add(this.chart1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimumSize = new System.Drawing.Size(880, 660);
            this.Name = "PlotGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PlotGraph";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minYearBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRatingBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxYearBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRatingBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TrackBar minYearBar;
        private System.Windows.Forms.TrackBar minRatingBar;
        private System.Windows.Forms.TrackBar maxYearBar;
        private System.Windows.Forms.TrackBar maxRatingBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LogoutLabel;
        private System.Windows.Forms.Label SeperatorBevel2;
        private System.Windows.Forms.Label SeperatorBevel1;
        private System.Windows.Forms.LinkLabel WatchListLabel;
        private System.Windows.Forms.LinkLabel manageCollectionLabel;
        private System.Windows.Forms.LinkLabel SearchLabel;
        private System.Windows.Forms.Label SearchFormTitleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaxYear;
        private System.Windows.Forms.Label lblMinYear;
        private System.Windows.Forms.Label lblMaxRat;
        private System.Windows.Forms.Label lblMinRat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}