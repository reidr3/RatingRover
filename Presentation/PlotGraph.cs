using RatingRover.Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RatingRover.Presentation
{
    public partial class PlotGraph : Form
    {
        MovieFilter filter = new MovieFilter();
        private List<DataPoint> labels = new List<DataPoint>();
        Chart chart2 = new Chart();
        
        public PlotGraph()
        {
            InitializeComponent();
            minYearBar.Minimum = 1903;                      //earliest movie in the list
            minYearBar.Value = minYearBar.Minimum;
           

            maxYearBar.Maximum = DateTime.Now.Year; 
            maxYearBar.Minimum = minYearBar.Value;          //Newest movie not earlier than today
            maxYearBar.Value = maxYearBar.Maximum;
            minYearBar.Maximum = maxYearBar.Value;
                  

            minRatingBar.Minimum = 0;
            minRatingBar.Value = minRatingBar.Minimum;
            

            maxRatingBar.Maximum = 10;
            maxRatingBar.Minimum = minRatingBar.Value;
            maxRatingBar.Value = maxRatingBar.Maximum;
            minRatingBar.Maximum = maxRatingBar.Value;

            lblMaxYear.Text = Convert.ToString(maxYearBar.Maximum);
            lblMinYear.Text = Convert.ToString(minYearBar.Minimum);
            lblMinRat.Text = Convert.ToString(minRatingBar.Minimum);
            lblMaxRat.Text = Convert.ToString(maxRatingBar.Maximum);

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 10;

            chart1.ChartAreas[0].AxisX.Minimum = minYearBar.Minimum;
            chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.Year;

            chart1.ChartAreas[0].AxisX.Interval = (DateTime.Now.Year - minYearBar.Minimum) / 4;

            graph_Display();
             
        }

        private void graph_Display()
        {
            List<Movie> movieList = filter.GetResult();
            chart1.Series[0].Points.Clear();
            int moviesAdded = 0;

            for (int i = 0; i < movieList.Count; i++)
            {
                if ((Int32.Parse(movieList.ElementAt(i).YearReleased) <= maxYearBar.Value) &&
                    (Int32.Parse(movieList.ElementAt(i).YearReleased) > minYearBar.Value) &&
                    (Int32.Parse(movieList.ElementAt(i).Rating) > minRatingBar.Value) &&
                    (Int32.Parse(movieList.ElementAt(i).Rating) <= maxRatingBar.Value))
                {
                    chart1.Series[0].Points.AddXY(Int32.Parse(movieList.ElementAt(i).YearReleased),Int32.Parse(movieList.ElementAt(i).Rating));
                    chart1.Series[0].Points[moviesAdded].Tag = movieList.ElementAt(i);
                    moviesAdded++;
                }
            }
        }

        private void minRatingBar_Scroll(object sender, EventArgs e)
        {
            if (minRatingBar.Value >= maxRatingBar.Value)
            {
                maxRatingBar.Value = minRatingBar.Value;
                maxRatingBar_Scroll(this, e);
            }

            for (int j = 0; j < chart1.Series[0].Points.Count; j++)
            {
                if (chart1.Series[0].Points[j].YValues[0] < minRatingBar.Value ||
                    chart1.Series[0].Points[j].YValues[0] > maxRatingBar.Value ||
                    chart1.Series[0].Points[j].XValue > maxYearBar.Value ||
                    chart1.Series[0].Points[j].XValue < minYearBar.Value)
                {
                    chart1.Series[0].Points[j].IsEmpty = true;
                }
                else
                {
                    chart1.Series[0].Points[j].IsEmpty = false;
                }
            }
            lblMinRat.Text = Convert.ToString(minRatingBar.Value);

 
        }  

        private void maxRatingBar_Scroll(object sender, EventArgs e)
        {
            if ( maxRatingBar.Value < minRatingBar.Value)
            {
                minRatingBar.Value = maxRatingBar.Value;
                minRatingBar_Scroll(this, e);
            }

            for (int j = 0; j < chart1.Series[0].Points.Count; j++)
            {
                if (chart1.Series[0].Points[j].YValues[0] > maxRatingBar.Value ||
                    chart1.Series[0].Points[j].YValues[0] < minRatingBar.Value ||
                    chart1.Series[0].Points[j].XValue > maxYearBar.Value ||
                    chart1.Series[0].Points[j].XValue < minYearBar.Value)
                {
                    chart1.Series[0].Points[j].IsEmpty = true;
                }
                else
                {
                    chart1.Series[0].Points[j].IsEmpty = false;
                }
            }
            lblMaxRat.Text = Convert.ToString(maxRatingBar.Value);
  
        }

        private void maxYearBar_Scroll(object sender, EventArgs e)
        {
            if (maxYearBar.Value < minYearBar.Value)
            {
                minYearBar.Value = maxYearBar.Value;
                minYearBar_Scroll(this, e);
            }

            for (int j = 0; j < chart1.Series[0].Points.Count; j++)
            {
                if (chart1.Series[0].Points[j].YValues[0] > maxRatingBar.Value ||
                    chart1.Series[0].Points[j].YValues[0] < minRatingBar.Value ||
                    chart1.Series[0].Points[j].XValue > maxYearBar.Value ||
                    chart1.Series[0].Points[j].XValue < minYearBar.Value)
                {
                    chart1.Series[0].Points[j].IsEmpty = true;
                }
                else
                {
                    chart1.Series[0].Points[j].IsEmpty = false;
                }
                lblMaxYear.Text = Convert.ToString(maxYearBar.Value);
            
             
            }
        }

        private void minYearBar_Scroll(object sender, EventArgs e)
        {
            if (minYearBar.Value >= maxYearBar.Value)
            {
                maxYearBar.Value = minYearBar.Value;
                maxYearBar_Scroll(this, e);
            }

            for (int j = 0; j < chart1.Series[0].Points.Count; j++)
            {
                if (chart1.Series[0].Points[j].YValues[0] > maxRatingBar.Value ||
                    chart1.Series[0].Points[j].YValues[0] < minRatingBar.Value ||
                    chart1.Series[0].Points[j].XValue > maxYearBar.Value ||
                    chart1.Series[0].Points[j].XValue < minYearBar.Value)
                {
                    chart1.Series[0].Points[j].IsEmpty = true;
                }
                else
                {
                    chart1.Series[0].Points[j].IsEmpty = false;
                }

                lblMinYear.Text = Convert.ToString(minYearBar.Value);
            }
        }

        private void SearchLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchForm search = new SearchForm();
            search.Size = this.Size;
            search.Location = this.Location;
            search.Show();
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

        private void manageCollectionLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageCollectionForm collectionForm = new ManageCollectionForm();
            collectionForm.Size = this.Size;
            collectionForm.Location = this.Location;
            collectionForm.Show();
            this.Close();
        }

        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Location = this.Location;
            login.Show();
            this.Close();
        }

        private void WatchListLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WatchListForm watchList = new WatchListForm();
            watchList.Size = this.Size;
            watchList.Location = this.Location;
            watchList.Show();
            this.Close();
        }

        private void manageCollectionLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ManageCollectionForm manageCollection = new ManageCollectionForm();
            manageCollection.Size = this.Size;
            manageCollection.Location = this.Location;
            manageCollection.Show();
            Cursor = Cursors.Default;
            this.Close();
        }

        private void chart1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Movie currentMovie;
            double x;
            double y;

            chart1.ChartAreas[0].CursorX.SetCursorPixelPosition(new Point(e.X, e.Y), true);
            chart1.ChartAreas[0].CursorY.SetCursorPixelPosition(new Point(e.X, e.Y), true);

            x = chart1.ChartAreas[0].CursorX.Position;
            y = chart1.ChartAreas[0].CursorY.Position;

            clearLabels();

            for (int i = 0; i < chart1.Series[0].Points.Count; i++)
            {
                currentMovie = (Movie)chart1.Series[0].Points[i].Tag;

                if (chart1.Series[0].Points[i].XValue == x && chart1.Series[0].Points[i].YValues[0] == y
                    && chart1.Series[0].Points[i].IsEmpty == false)
                {

                    chart1.Series[0].Points[i].Label = currentMovie.Title;
                    labels.Add(chart1.Series[0].Points[i]);

                }
            }
            
        }


        private void clearLabels()
        {
            for( int i = 0; i < labels.Count; i++)
            {
                labels.ElementAt(i).Label = "";
            }

            labels.Clear();
        }

        private void maxRatingBar_Leave(object sender, EventArgs e)
        {
            if (maxRatingBar.Value < minRatingBar.Value)
            {
                maxRatingBar.Value = minRatingBar.Value;
            }
        }

        private void minRatingBar_Leave(object sender, EventArgs e)
        {
            if (minRatingBar.Value > maxRatingBar.Value)
            {
                minRatingBar.Value = maxRatingBar.Value;
            }
        }

        private void chart1_MouseLeave(object sender, EventArgs e)
        {
            clearLabels();
        }
    }
}