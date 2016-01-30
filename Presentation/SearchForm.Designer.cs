namespace RatingRover
{
    partial class SearchForm
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.SearchFormTitleLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.LinkLabel();
            this.manageCollectionLabel = new System.Windows.Forms.LinkLabel();
            this.WatchListLabel = new System.Windows.Forms.LinkLabel();
            this.SeperatorBevel1 = new System.Windows.Forms.Label();
            this.SeperatorBevel2 = new System.Windows.Forms.Label();
            this.TopBevel = new System.Windows.Forms.Label();
            this.VerticalSeperaterBevel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MovieGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.RecMoviesLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LogoutLabel = new System.Windows.Forms.LinkLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newRecLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PlotGraph = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.MovieGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchFormTitleLabel
            // 
            this.SearchFormTitleLabel.AutoSize = true;
            this.SearchFormTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SearchFormTitleLabel.Location = new System.Drawing.Point(67, 18);
            this.SearchFormTitleLabel.Name = "SearchFormTitleLabel";
            this.SearchFormTitleLabel.Size = new System.Drawing.Size(252, 31);
            this.SearchFormTitleLabel.TabIndex = 2;
            this.SearchFormTitleLabel.Text = "Movie Rating Rover";
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.SearchLabel.LinkColor = System.Drawing.Color.Black;
            this.SearchLabel.Location = new System.Drawing.Point(73, 53);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(41, 13);
            this.SearchLabel.TabIndex = 3;
            this.SearchLabel.TabStop = true;
            this.SearchLabel.Text = "Search";
            // 
            // manageCollectionLabel
            // 
            this.manageCollectionLabel.AutoSize = true;
            this.manageCollectionLabel.Location = new System.Drawing.Point(135, 53);
            this.manageCollectionLabel.Name = "manageCollectionLabel";
            this.manageCollectionLabel.Size = new System.Drawing.Size(95, 13);
            this.manageCollectionLabel.TabIndex = 5;
            this.manageCollectionLabel.TabStop = true;
            this.manageCollectionLabel.Text = "Manage Collection";
            this.manageCollectionLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.manageCollectionLabel_LinkClicked);
            // 
            // WatchListLabel
            // 
            this.WatchListLabel.AutoSize = true;
            this.WatchListLabel.Location = new System.Drawing.Point(251, 53);
            this.WatchListLabel.Name = "WatchListLabel";
            this.WatchListLabel.Size = new System.Drawing.Size(55, 13);
            this.WatchListLabel.TabIndex = 6;
            this.WatchListLabel.TabStop = true;
            this.WatchListLabel.Text = "WatchList";
            this.WatchListLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WatchListLabel_LinkClicked);
            // 
            // SeperatorBevel1
            // 
            this.SeperatorBevel1.AutoSize = true;
            this.SeperatorBevel1.Location = new System.Drawing.Point(120, 53);
            this.SeperatorBevel1.Name = "SeperatorBevel1";
            this.SeperatorBevel1.Size = new System.Drawing.Size(9, 13);
            this.SeperatorBevel1.TabIndex = 6;
            this.SeperatorBevel1.Text = "|";
            // 
            // SeperatorBevel2
            // 
            this.SeperatorBevel2.AutoSize = true;
            this.SeperatorBevel2.Location = new System.Drawing.Point(236, 53);
            this.SeperatorBevel2.Name = "SeperatorBevel2";
            this.SeperatorBevel2.Size = new System.Drawing.Size(9, 13);
            this.SeperatorBevel2.TabIndex = 7;
            this.SeperatorBevel2.Text = "|";
            // 
            // TopBevel
            // 
            this.TopBevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopBevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TopBevel.Location = new System.Drawing.Point(12, 75);
            this.TopBevel.Name = "TopBevel";
            this.TopBevel.Size = new System.Drawing.Size(620, 2);
            this.TopBevel.TabIndex = 8;
            // 
            // VerticalSeperaterBevel
            // 
            this.VerticalSeperaterBevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VerticalSeperaterBevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VerticalSeperaterBevel.Location = new System.Drawing.Point(330, 109);
            this.VerticalSeperaterBevel.Name = "VerticalSeperaterBevel";
            this.VerticalSeperaterBevel.Size = new System.Drawing.Size(2, 200);
            this.VerticalSeperaterBevel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(395, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Recommended Movies";
            // 
            // MovieGraph
            // 
            this.MovieGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.MovieGraph.ChartAreas.Add(chartArea1);
            this.MovieGraph.Location = new System.Drawing.Point(389, 137);
            this.MovieGraph.Name = "MovieGraph";
            this.MovieGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.LabelForeColor = System.Drawing.Color.DarkRed;
            series1.Name = "Series1";
            this.MovieGraph.Series.Add(series1);
            this.MovieGraph.Size = new System.Drawing.Size(207, 175);
            this.MovieGraph.TabIndex = 11;
            this.MovieGraph.Text = "chart1";
            title1.Name = "Movie Plotter";
            title1.Text = "Movie Plotter";
            this.MovieGraph.Titles.Add(title1);
            this.MovieGraph.MouseLeave += new System.EventHandler(this.MovieGraph_MouseLeave);
            this.MovieGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovieGraph_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(71, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Movie Title Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(76, 201);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(170, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(246, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(183, 236);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Advanced Search";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(620, 2);
            this.label3.TabIndex = 16;
            // 
            // RecMoviesLabel
            // 
            this.RecMoviesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecMoviesLabel.AutoSize = true;
            this.RecMoviesLabel.Location = new System.Drawing.Point(12, 334);
            this.RecMoviesLabel.Name = "RecMoviesLabel";
            this.RecMoviesLabel.Size = new System.Drawing.Size(122, 13);
            this.RecMoviesLabel.TabIndex = 17;
            this.RecMoviesLabel.Text = "Recommended Movies: ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(12, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(620, 2);
            this.label5.TabIndex = 18;
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.Location = new System.Drawing.Point(592, 53);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(40, 13);
            this.LogoutLabel.TabIndex = 8;
            this.LogoutLabel.TabStop = true;
            this.LogoutLabel.Text = "Logout";
            this.LogoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLabel_LinkClicked);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.Location = new System.Drawing.Point(12, 360);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(620, 238);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // newRecLabel
            // 
            this.newRecLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newRecLabel.AutoSize = true;
            this.newRecLabel.Location = new System.Drawing.Point(499, 334);
            this.newRecLabel.Name = "newRecLabel";
            this.newRecLabel.Size = new System.Drawing.Size(133, 13);
            this.newRecLabel.TabIndex = 4;
            this.newRecLabel.TabStop = true;
            this.newRecLabel.Text = "Get new recommendations";
            this.newRecLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newRecLabel_LinkClicked);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(9, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "|";
            // 
            // PlotGraph
            // 
            this.PlotGraph.AutoSize = true;
            this.PlotGraph.Location = new System.Drawing.Point(328, 53);
            this.PlotGraph.Name = "PlotGraph";
            this.PlotGraph.Size = new System.Drawing.Size(57, 13);
            this.PlotGraph.TabIndex = 7;
            this.PlotGraph.TabStop = true;
            this.PlotGraph.Text = "Plot Graph";
            this.PlotGraph.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PlotGraph_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(399, 334);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(79, 13);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "View all movies";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(9, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "|";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 604);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(620, 11);
            this.progressBar1.TabIndex = 80;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(644, 625);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.PlotGraph);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.newRecLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.LogoutLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RecMoviesLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchTextBox);
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
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SearchForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.MovieGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchFormTitleLabel;
        private System.Windows.Forms.LinkLabel SearchLabel;
        private System.Windows.Forms.LinkLabel manageCollectionLabel;
        private System.Windows.Forms.LinkLabel WatchListLabel;
        private System.Windows.Forms.Label SeperatorBevel1;
        private System.Windows.Forms.Label SeperatorBevel2;
        private System.Windows.Forms.Label TopBevel;
        private System.Windows.Forms.Label VerticalSeperaterBevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart MovieGraph;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RecMoviesLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel LogoutLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.LinkLabel newRecLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel PlotGraph;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}