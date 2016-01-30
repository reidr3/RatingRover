using RatingRover.Business;
using RatingRover.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RatingRover
{
    public partial class SearchForm : Form
    {
        private List<DataPoint> labelsShown = new List<DataPoint>();

        public SearchForm()
        {
            InitializeComponent();
            ShowRecommended();
        }

        private void ShowGraph(List<Movie> movieList)
        {
            MovieGraph.Series[0].Points.Clear();
            int minRating = 0;
            int maxRating = 10;
            int currentYear = DateTime.Now.Year;
            int startYear = 1900;
            int moviesAdded = 0;

            MovieGraph.Series[0].SmartLabelStyle.Enabled = true;
            MovieGraph.ChartAreas[0].AxisX.Minimum = startYear;
            MovieGraph.ChartAreas[0].AxisX.Maximum = currentYear;
            MovieGraph.ChartAreas[0].AxisX.Title = "Year";
            MovieGraph.ChartAreas[0].AxisY.Minimum = minRating;
            MovieGraph.ChartAreas[0].AxisY.Maximum = maxRating;
            MovieGraph.ChartAreas[0].AxisY.Title = "Rating";
            MovieGraph.ChartAreas[0].AxisX.Interval = (currentYear - startYear) / 5;
            MovieGraph.ChartAreas[0].AxisY.Interval = 2;

            for (int i = 0; i < movieList.Count; i++)
            {
                if ((Int32.Parse(movieList.ElementAt(i).YearReleased) <= currentYear) &&
                    (Int32.Parse(movieList.ElementAt(i).YearReleased) > startYear) &&
                    (Int32.Parse(movieList.ElementAt(i).Rating) > minRating) &&
                    (Int32.Parse(movieList.ElementAt(i).Rating) <= maxRating))
                {
                    MovieGraph.Series[0].Points.AddXY(Int32.Parse(movieList.ElementAt(i).YearReleased), Int32.Parse(movieList.ElementAt(i).Rating));
                    MovieGraph.Series[0].Points[moviesAdded].Tag = movieList.ElementAt(i);
                    moviesAdded++;
                }
            }

            if(MovieGraph.Series[0].Points.Count == 0)
            {
                MovieGraph.Series[0].Points.AddXY(0, 0);
            }
        }

        private void ShowRecommended()
        {
            if (Program.recommendationList.Count == 0)
            {
                Program.FillListView(listView1);
                ShowGraph(Program.recommendationList);

            } else
            {
                PopulateView(Program.recommendationList);
                ShowGraph(Program.recommendationList);
            }
        }

        public void PopulateView(List<Movie> movieList)
        {
            int items = movieList.Count;
            listView1.Items.Clear();
            ShowGraph(movieList);

            for (int i = 0; i < items; i++)
            {
                listView1.Items.Add(movieList.ElementAt(i).ToListViewItem());
                progressBar1.Value = (100 * i) / items;
            }
            progressBar1.Value = 0;
            
        }

        private void manageCollectionLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ManageCollectionForm collectionForm = new ManageCollectionForm();
            collectionForm.Size = this.Size;
            collectionForm.Location = this.Location;
            collectionForm.Show();
            Cursor = Cursors.Default;
            this.Close();
        }

        private void WatchListLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WatchListForm watchList = new WatchListForm();
            watchList.Size = this.Size;
            watchList.Location = this.Location;
            watchList.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Movie> results = new List<Movie>();
            MovieFilter filter = new MovieFilter();
            listView1.Items.Clear();

            filter.FilterTitle(searchTextBox.Text);
            results = filter.GetResult();
            PopulateView(results);
            RecMoviesLabel.Text = "Search Results";
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            MovieForm movieDisplay = new MovieForm();

            if( listView1.SelectedItems.Count > 0)
            {
                movieDisplay.FillForm(listView1.SelectedItems[0]);
                movieDisplay.Size = this.Size;
                movieDisplay.Location = this.Location;
                movieDisplay.Show();
                this.Close();
            } 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdvancedSearch advSearch = new AdvancedSearch();
            advSearch.Size = this.Size;
            advSearch.Location = this.Location;
            advSearch.Show();
            this.Close();
        }

        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Location = this.Location;
            login.Show();
            this.Close();
        }

        private void newRecLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecMoviesLabel.Text = "Recommended Movies:";

            listView1.Items.Clear();
            Program.FillListView(listView1);
            ShowGraph(Program.recommendationList);
        }

        private void PlotGraph_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PlotGraph plotGraph = new PlotGraph();
            plotGraph.Size = this.Size;
            plotGraph.Location = this.Location;
            plotGraph.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MovieFilter filter = new MovieFilter();

            
            PopulateView(filter.GetResult());
        }

        private void SearchForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if( searchTextBox.Focused == true)
                {
                    button1_Click(this, e);
                }
            }
        }

        private void MovieGraph_MouseMove(object sender, MouseEventArgs e)
        {
            Movie currentMovie;
            double x;
            double y;
            HitTestResult result = MovieGraph.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                clearLabels();
                DataPoint point = MovieGraph.Series[0].Points[result.PointIndex];
                x = point.XValue;
                y = point.YValues[0];
                currentMovie = (Movie)point.Tag;
                point.Label = currentMovie.Title;
                labelsShown.Add(point);

                for (int i = 1; i < MovieGraph.Series[0].Points.Count; i++)
                {
                    if (MovieGraph.Series[0].Points.ElementAt(i).XValue == x && MovieGraph.Series[0].Points.ElementAt(i).YValues[0] == y)
                    {
                        currentMovie = (Movie)MovieGraph.Series[0].Points.ElementAt(i).Tag;
                        MovieGraph.Series[0].Points.ElementAt(i).Label = currentMovie.Title;
                        labelsShown.Add(MovieGraph.Series[0].Points.ElementAt(i));
                    }
                }
            }
        }

        private void clearLabels()
        {
            for (int i = 0; i < labelsShown.Count; i++)
            {
                labelsShown.ElementAt(i).Label = "";
            }

            labelsShown.Clear();
        }

        private void MovieGraph_MouseLeave(object sender, EventArgs e)
        {
            clearLabels();
        }
    }
}
