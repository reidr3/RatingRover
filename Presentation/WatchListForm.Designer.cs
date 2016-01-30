namespace RatingRover
{
    partial class WatchListForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.DescendingCheckBox = new System.Windows.Forms.CheckBox();
            this.AscendingCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FilterSelection = new System.Windows.Forms.ComboBox();
            this.LogoutLabel = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MovieGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.VerticalSeperaterBevel = new System.Windows.Forms.Label();
            this.TopBevel = new System.Windows.Forms.Label();
            this.SeperatorBevel2 = new System.Windows.Forms.Label();
            this.SeperatorBevel1 = new System.Windows.Forms.Label();
            this.WatchListLabel = new System.Windows.Forms.LinkLabel();
            this.manageCollectionLabel = new System.Windows.Forms.LinkLabel();
            this.SearchLabel = new System.Windows.Forms.LinkLabel();
            this.SearchFormTitleLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PlotGraph = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.MovieGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DescendingCheckBox
            // 
            this.DescendingCheckBox.AutoSize = true;
            this.DescendingCheckBox.Location = new System.Drawing.Point(138, 214);
            this.DescendingCheckBox.Name = "DescendingCheckBox";
            this.DescendingCheckBox.Size = new System.Drawing.Size(83, 17);
            this.DescendingCheckBox.TabIndex = 1;
            this.DescendingCheckBox.Text = "Descending";
            this.DescendingCheckBox.UseVisualStyleBackColor = true;
            this.DescendingCheckBox.CheckedChanged += new System.EventHandler(this.DescendingCheckBox_CheckedChanged);
            // 
            // AscendingCheckBox
            // 
            this.AscendingCheckBox.AutoSize = true;
            this.AscendingCheckBox.Checked = true;
            this.AscendingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AscendingCheckBox.Location = new System.Drawing.Point(138, 191);
            this.AscendingCheckBox.Name = "AscendingCheckBox";
            this.AscendingCheckBox.Size = new System.Drawing.Size(76, 17);
            this.AscendingCheckBox.TabIndex = 0;
            this.AscendingCheckBox.Text = "Ascending";
            this.AscendingCheckBox.UseVisualStyleBackColor = true;
            this.AscendingCheckBox.CheckedChanged += new System.EventHandler(this.AscendingCheckBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Filter";
            // 
            // FilterSelection
            // 
            this.FilterSelection.FormattingEnabled = true;
            this.FilterSelection.Items.AddRange(new object[] {
            "Movie Title",
            "Year of Release",
            "Rating"});
            this.FilterSelection.Location = new System.Drawing.Point(79, 237);
            this.FilterSelection.Name = "FilterSelection";
            this.FilterSelection.Size = new System.Drawing.Size(135, 21);
            this.FilterSelection.TabIndex = 2;
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.Location = new System.Drawing.Point(592, 53);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(40, 13);
            this.LogoutLabel.TabIndex = 7;
            this.LogoutLabel.TabStop = true;
            this.LogoutLabel.Text = "Logout";
            this.LogoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLabel_LinkClicked);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(12, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(620, 2);
            this.label5.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "WatchList: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(620, 2);
            this.label3.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(71, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Watchlist";
            // 
            // MovieGraph
            // 
            this.MovieGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.MovieGraph.ChartAreas.Add(chartArea1);
            this.MovieGraph.Location = new System.Drawing.Point(386, 134);
            this.MovieGraph.Name = "MovieGraph";
            this.MovieGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.LabelForeColor = System.Drawing.Color.DarkRed;
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            this.MovieGraph.Series.Add(series1);
            this.MovieGraph.Size = new System.Drawing.Size(207, 175);
            this.MovieGraph.TabIndex = 51;
            this.MovieGraph.Text = "chart1";
            title1.Name = "Movie Plotter";
            title1.Text = "Movie Plotter";
            this.MovieGraph.Titles.Add(title1);
            this.MovieGraph.MouseLeave += new System.EventHandler(this.MovieGraph_MouseLeave);
            this.MovieGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(410, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Watchlist Collection";
            // 
            // VerticalSeperaterBevel
            // 
            this.VerticalSeperaterBevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VerticalSeperaterBevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VerticalSeperaterBevel.Location = new System.Drawing.Point(330, 109);
            this.VerticalSeperaterBevel.Name = "VerticalSeperaterBevel";
            this.VerticalSeperaterBevel.Size = new System.Drawing.Size(2, 200);
            this.VerticalSeperaterBevel.TabIndex = 49;
            // 
            // TopBevel
            // 
            this.TopBevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopBevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TopBevel.Location = new System.Drawing.Point(12, 75);
            this.TopBevel.Name = "TopBevel";
            this.TopBevel.Size = new System.Drawing.Size(620, 2);
            this.TopBevel.TabIndex = 48;
            // 
            // SeperatorBevel2
            // 
            this.SeperatorBevel2.AutoSize = true;
            this.SeperatorBevel2.Location = new System.Drawing.Point(236, 53);
            this.SeperatorBevel2.Name = "SeperatorBevel2";
            this.SeperatorBevel2.Size = new System.Drawing.Size(9, 13);
            this.SeperatorBevel2.TabIndex = 47;
            this.SeperatorBevel2.Text = "|";
            // 
            // SeperatorBevel1
            // 
            this.SeperatorBevel1.AutoSize = true;
            this.SeperatorBevel1.Location = new System.Drawing.Point(120, 53);
            this.SeperatorBevel1.Name = "SeperatorBevel1";
            this.SeperatorBevel1.Size = new System.Drawing.Size(9, 13);
            this.SeperatorBevel1.TabIndex = 46;
            this.SeperatorBevel1.Text = "|";
            // 
            // WatchListLabel
            // 
            this.WatchListLabel.AutoSize = true;
            this.WatchListLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.WatchListLabel.LinkColor = System.Drawing.Color.Black;
            this.WatchListLabel.Location = new System.Drawing.Point(251, 53);
            this.WatchListLabel.Name = "WatchListLabel";
            this.WatchListLabel.Size = new System.Drawing.Size(55, 13);
            this.WatchListLabel.TabIndex = 45;
            this.WatchListLabel.TabStop = true;
            this.WatchListLabel.Text = "WatchList";
            // 
            // manageCollectionLabel
            // 
            this.manageCollectionLabel.AutoSize = true;
            this.manageCollectionLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.manageCollectionLabel.LinkColor = System.Drawing.Color.Blue;
            this.manageCollectionLabel.Location = new System.Drawing.Point(135, 53);
            this.manageCollectionLabel.Name = "manageCollectionLabel";
            this.manageCollectionLabel.Size = new System.Drawing.Size(95, 13);
            this.manageCollectionLabel.TabIndex = 5;
            this.manageCollectionLabel.TabStop = true;
            this.manageCollectionLabel.Text = "Manage Collection";
            this.manageCollectionLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.manageCollectionLabel_LinkClicked);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.SearchLabel.LinkColor = System.Drawing.Color.Blue;
            this.SearchLabel.Location = new System.Drawing.Point(73, 53);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(41, 13);
            this.SearchLabel.TabIndex = 4;
            this.SearchLabel.TabStop = true;
            this.SearchLabel.Text = "Search";
            this.SearchLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SearchLabel_LinkClicked);
            // 
            // SearchFormTitleLabel
            // 
            this.SearchFormTitleLabel.AutoSize = true;
            this.SearchFormTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SearchFormTitleLabel.Location = new System.Drawing.Point(67, 18);
            this.SearchFormTitleLabel.Name = "SearchFormTitleLabel";
            this.SearchFormTitleLabel.Size = new System.Drawing.Size(252, 31);
            this.SearchFormTitleLabel.TabIndex = 42;
            this.SearchFormTitleLabel.Text = "Movie Rating Rover";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.Location = new System.Drawing.Point(12, 374);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(620, 238);
            this.listView1.TabIndex = 61;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 21);
            this.button1.TabIndex = 3;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RatingRover.Properties.Resources.test;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(9, 13);
            this.label7.TabIndex = 81;
            this.label7.Text = "|";
            // 
            // PlotGraph
            // 
            this.PlotGraph.AutoSize = true;
            this.PlotGraph.Location = new System.Drawing.Point(327, 53);
            this.PlotGraph.Name = "PlotGraph";
            this.PlotGraph.Size = new System.Drawing.Size(57, 13);
            this.PlotGraph.TabIndex = 6;
            this.PlotGraph.TabStop = true;
            this.PlotGraph.Text = "Plot Graph";
            this.PlotGraph.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PlotGraph_LinkClicked);
            // 
            // WatchListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 625);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PlotGraph);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DescendingCheckBox);
            this.Controls.Add(this.AscendingCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FilterSelection);
            this.Controls.Add(this.LogoutLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MovieGraph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VerticalSeperaterBevel);
            this.Controls.Add(this.TopBevel);
            this.Controls.Add(this.SeperatorBevel2);
            this.Controls.Add(this.SeperatorBevel1);
            this.Controls.Add(this.WatchListLabel);
            this.Controls.Add(this.manageCollectionLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchFormTitleLabel);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(660, 663);
            this.Name = "WatchListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Watch List";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WatchListForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.MovieGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DescendingCheckBox;
        private System.Windows.Forms.CheckBox AscendingCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FilterSelection;
        private System.Windows.Forms.LinkLabel LogoutLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart MovieGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VerticalSeperaterBevel;
        private System.Windows.Forms.Label TopBevel;
        private System.Windows.Forms.Label SeperatorBevel2;
        private System.Windows.Forms.Label SeperatorBevel1;
        private System.Windows.Forms.LinkLabel WatchListLabel;
        private System.Windows.Forms.LinkLabel manageCollectionLabel;
        private System.Windows.Forms.LinkLabel SearchLabel;
        private System.Windows.Forms.Label SearchFormTitleLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel PlotGraph;
    }
}