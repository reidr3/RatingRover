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

namespace RatingRover
{
    public partial class ManageCollectionForm : Form
    {
        private int currentAmount = 0;

        public ManageCollectionForm()
        {
            InitializeComponent();
            PopulateView();

        }

        private void PopulateView( List<Movie> results)
        {
            int oldWidth = getMoreLabel.Width;
            getMoreLabel.Text = "View Collection";
            getMoreLabel.Left = getMoreLabel.Location.X + (oldWidth - getMoreLabel.Width);

            for (int i = 0; i < results.Count; i++)
            {
                listView1.Items.Add(Program.movieList.ElementAt(i).ToListViewItem());
                progressBar1.Value = (100 * i) / results.Count;
            }

            progressBar1.Value = 0;

            currentAmount = 0;
        }

        private void PopulateView()
        {
            int oldWidth = getMoreLabel.Width;

            getMoreLabel.Text = "Get More";
            getMoreLabel.Left = getMoreLabel.Location.X + (oldWidth - getMoreLabel.Width);



            if ( currentAmount == 0)
            {
                listView1.Items.Clear();
            }

            int endAmount = currentAmount + 500;

            if( endAmount >= Program.movieList.Count)
            {
                endAmount = Program.movieList.Count;
            }

            if (Program.movieList.Count > 0)
            {
                for (;currentAmount < endAmount; currentAmount++)
                {
               
                    listView1.Items.Add(Program.movieList.ElementAt(currentAmount).ToListViewItem());
                    progressBar1.Value = (100 * currentAmount) / endAmount;
                }
            }

            progressBar1.Value = 0;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if( DescendingCheckBox.Checked == true )
            {
                AscendingCheckBox.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (AscendingCheckBox.Checked == true)
            {
                DescendingCheckBox.Checked = false;
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

        private void Filter_Click(object sender, EventArgs e)
        {
            MovieFilter filter = new MovieFilter(Program.movieList);

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

                listView1.Items.Clear();
                PopulateView( filter.GetResult());
            }

        }

        private void DescendingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DescendingCheckBox.Checked == true)
            {
                AscendingCheckBox.Checked = false;
            }
        }

        private void AscendingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AscendingCheckBox.Checked == true)
            {
                DescendingCheckBox.Checked = false;
            }
            else
            {
                DescendingCheckBox.Checked = true;
            }
        }

        private void AddMovieLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditMovieForm addMovie = new EditMovieForm(this);
            addMovie.Location = this.Location;
            addMovie.Show();
            this.Visible = false;
        }

        private void PlotGraph_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PlotGraph plotGraph = new PlotGraph();
            plotGraph.Size = this.Size;
            plotGraph.Location = this.Location;
            plotGraph.Show();
            this.Close();
        }

        private void getMoreLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PopulateView();
        }

        private void ManageCollectionForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if( FilterSelection.SelectedItem != null )
                {
                    Filter_Click(this, e);
                }
            }
        }
    }
}

