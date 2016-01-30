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
    public partial class MovieForm : Form
    {
        private Movie displayedMovie;

        private const String removeWatch = "Remove from Watchlist";
        private const String addWatch = "Add to watchlist";

        public MovieForm()
        {
            InitializeComponent();
        }

        public void Refresh(Movie newMovie)
        {
            FillForm(newMovie);
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Location = this.Location;
            login.Show();
            this.Close();
        }

        public void FillForm(ListViewItem selectedItem)
        {
            Movie movie = (Movie)selectedItem.Tag;
            FillForm(movie);

        }

        public void FillForm(Movie movie)
        {
            displayedMovie = movie;
            int totalActors = movie.GetActors().Count;
            int totalGenres = movie.GetGenres().Count;

            movieTitleLabel.Text = movie.Title;
            YearCreatedField.Text = movie.YearReleased;
            DirectorField.Text = movie.Director;
            RatingField.Text = movie.Rating;

            if (movie.UserRatings == null)
            {
                UserRatingsField.Text = "No user ratings";
            }
            else
            {
                UserRatingsField.Text = movie.UserRatings;
            }

            for (int i = 0; i < totalActors; i++)
            {
                if (i == 0)
                {
                    ActorsField.Text = movie.GetActors().ElementAt(i).ToString();
                }
                else
                {
                    ActorsField.Text += "\n" + movie.GetActors().ElementAt(i).ToString();
                }

            }

            for (int i = 0; i < totalGenres; i++)
            {

                if (i == 0)
                {
                    GenreField.Text = movie.GetGenres().ElementAt(i).ToString();
                }
                else
                {
                    GenreField.Text += "\n" + movie.GetGenres().ElementAt(i).ToString();
                }

            }

            this.Text = movieTitleLabel.Text;

            if (Program.watchList.Contains(displayedMovie) == true)
            {
                int startWidth = AddToWatchListLabel.Size.Width;
                AddToWatchListLabel.Text = removeWatch;
                int newWidth = AddToWatchListLabel.Size.Width;

                label2.Left = label2.Location.X + (newWidth - startWidth);
                EditMovieLabel.Left = EditMovieLabel.Location.X + (newWidth - startWidth);
            }
        }

        private void AddToWatchListLabel_linkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Program.watchList.Contains(displayedMovie) == false && AddToWatchListLabel.Text == addWatch)
            {
                Program.watchList.Add(displayedMovie);
                Program.UpdateWatchList();

                int startWidth = AddToWatchListLabel.Size.Width;
                AddToWatchListLabel.Text = removeWatch;
                int newWidth = AddToWatchListLabel.Size.Width;

                label2.Left = label2.Location.X + (newWidth - startWidth);
                EditMovieLabel.Left = EditMovieLabel.Location.X + (newWidth - startWidth);
            }
            else if (AddToWatchListLabel.Text == removeWatch)
            {
                Program.watchList.Remove(displayedMovie);
                Program.UpdateWatchList();

                int startWidth = AddToWatchListLabel.Size.Width;
                AddToWatchListLabel.Text = addWatch;
                int newWidth = AddToWatchListLabel.Size.Width;

                label2.Left = label2.Location.X + (newWidth - startWidth);
                EditMovieLabel.Left = EditMovieLabel.Location.X + (newWidth - startWidth);
            }

        }

        private void EditMovieLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditMovieForm editMovie = new EditMovieForm(this);
            editMovie.Populate(displayedMovie);
            editMovie.Location = this.Location;
            editMovie.Show();
            this.Visible = false;
        }

        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Location = this.Location;
            login.Show();
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
    }
}
