using RatingRover.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatingRover.Presentation
{
    public partial class AdvancedSearch : Form
    {
        public AdvancedSearch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm();
            search.Size = this.Size;
            search.Location = this.Location;
            search.Show();
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

        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Location = this.Location;
            login.Show();
            this.Close();
        }

        private void advSearchSubmit_Click(object sender, EventArgs e)
        {
            List<Movie> movieReults = new List<Movie>();
            MovieFilter filter = new MovieFilter();
            Cursor = Cursors.WaitCursor;

            if( titleTextBox.Text.Trim().Length > 0 )
            {
                filter.FilterTitle(titleTextBox.Text.Trim());
            }

            if( YearOfReleaseText.Text.Trim().Length > 0)
            {
                filter.FilterExactYear(Convert.ToInt32(YearOfReleaseText.Text.Trim()));
            }

            if( DirectorTextBox.Text.Trim().Length > 0)
            {
                filter.FilterDirector(DirectorTextBox.Text.Trim());
            }

            if( MinimumRatingText.Text.Trim().Length > 0)
            {
                filter.FilterMinRating(MinimumRatingText.Text.Trim());
            }

            if( actorTextBox.Text.Trim().Length > 0 )
            {
                filter.FilterActor(actorTextBox.Text.Trim());
            }

            if( GenreTextBox.Text.Trim().Length > 0 )
            {
                filter.FilterGenre(GenreTextBox.Text.Trim());
            }

            movieReults = filter.GetResult();
            SearchForm search = new SearchForm();
            search.PopulateView(movieReults);
            search.Show();
            Cursor = Cursors.Default;
            this.Close();
        }

        private void PlotGraph_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PlotGraph plotGraph = new PlotGraph();
            plotGraph.Size = this.Size;
            plotGraph.Location = this.Location;
            plotGraph.Show();
            this.Close();
        }

        private void AdvancedSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                advSearchSubmit_Click(this, e);
            }
        }
    }
}
