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
    public partial class WatchListForm : Form
    {
        private List<DataPoint> labels = new List<DataPoint>();

        public WatchListForm()
        {
            InitializeComponent();
            PopulateView();
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

            if(MovieGraph.Series[0].Points.Count == 0 )
            {
                MovieGraph.Series[0].Points.AddXY(0, 0);
            }
        }

        private void PopulateView()
        {

            listView1.Items.Clear();

            if (Program.watchList.Count > 0)
            {
                for (int i = 0; i < Program.watchList.Count; i++)
                {
                    listView1.Items.Add(Program.watchList.ElementAt(i).ToListViewItem());
                }
            }

            ShowGraph(Program.watchList);
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

        private void SearchLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchForm search = new SearchForm();
            search.Size = this.Size;
            search.Location = this.Location;
            search.Show();
            this.Close();
        }

        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Location = this.Location;
            login.Show();
            this.Close();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            MovieForm movieDisplay = new MovieForm();

            if (listView1.SelectedItems.Count > 0)
            {
                movieDisplay.FillForm(listView1.SelectedItems[0]);
                movieDisplay.Size = this.Size;
                movieDisplay.Location = this.Location;
                movieDisplay.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovieFilter filter = new MovieFilter(Program.watchList);

            if( FilterSelection.SelectedItem != null )
            {
                if (FilterSelection.SelectedItem.ToString() == "Movie Title")
                {
                    filter.SortTitle(AscendingCheckBox.Checked);

                }
                else if (FilterSelection.SelectedItem.ToString() == "Year of Release")
                {
                    filter.SortYear(AscendingCheckBox.Checked);

                }
                else
                {
                    filter.SortRating(AscendingCheckBox.Checked);
                }

                PopulateView();
            }
        }

        private void DescendingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if( DescendingCheckBox.Checked == true )
            {
                AscendingCheckBox.Checked = false;
            }
        }

        private void AscendingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if( AscendingCheckBox.Checked == true )
            {
                DescendingCheckBox.Checked = false;
            } else
            {
                DescendingCheckBox.Checked = true;
            }
        }

        private void PlotGraph_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PlotGraph plotGraph = new PlotGraph();
            plotGraph.Location = this.Location;
            plotGraph.Show();
            this.Close();
        
        }

        private void WatchListForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if( FilterSelection.SelectedItem != null )
                {
                    button1_Click(this, e);
                }
            }
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
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

                for (int i = 0; i < MovieGraph.Series[0].Points.Count; i++)
                {
                    if (MovieGraph.Series[0].Points.ElementAt(i).XValue == x && MovieGraph.Series[0].Points.ElementAt(i).YValues[0] == y)
                    {
                        currentMovie = (Movie)MovieGraph.Series[0].Points.ElementAt(i).Tag;
                        MovieGraph.Series[0].Points.ElementAt(i).Label = currentMovie.Title;
                        labels.Add(MovieGraph.Series[0].Points.ElementAt(i));
                    }
                }
            }
        }

        private void clearLabels()
        {
            for (int i = 0; i < labels.Count; i++)
            {
                labels.ElementAt(i).Label = "";
            }

            labels.Clear();
        }

        private void MovieGraph_MouseLeave(object sender, EventArgs e)
        {
            clearLabels();
        }

        private void W(object sender, EventArgs e)
        {

        }
    }
}
