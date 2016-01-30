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
    public partial class EditMovieForm : Form
    {
        private Form sentBy;
        private MovieForm returnMovie;
        private Movie editingMovie;

        public EditMovieForm(MovieForm sender)
        {
            editingMovie = null;
            sentBy = sender;
            returnMovie = sender;
            InitializeComponent();
        }

        public EditMovieForm(ManageCollectionForm sender)
        {
            editingMovie = null;
            sentBy = sender;
            InitializeComponent();
            MakeAddForm();
        }

        private void MakeAddForm()
        {
            this.Text = "Add Movie";
            EditMovieLabel.Text = "Add Movie";
            deleteMovieButton.Visible = false;
            deleteMovieButton.Enabled = false;
            ActorsComboBox.Text = "After typing an actor, press add";
            GenresComboBox.Text = "After typing a genre, press add";
        }

        private void CancelEditButton_Click(object sender, EventArgs e)
        {
            sentBy.Location = this.Location;
            sentBy.Show();
            this.Close();
        }

        public void Populate(Movie displayMovie)
        {
            editingMovie = displayMovie;
            int actors = displayMovie.TotalActors();
            int genres = displayMovie.TotalGenres();
            List<String> actorList = displayMovie.GetActors();
            List<String> genreList = displayMovie.GetGenres();

            titleTextBox.Text = displayMovie.Title;
            DirectorTextBox.Text = displayMovie.Director;
            RatingTextBox.Text = displayMovie.Rating;
            YoCTextBox.Text = displayMovie.YearReleased;
            LengthTextBox.Text = displayMovie.RunningTime;

            for (int i = 0; i < actors; i++)
            {
                ActorsComboBox.Items.Add(actorList.ElementAt(i));
            }

            for (int i = 0; i < genres; i++)
            {
                GenresComboBox.Items.Add(genreList.ElementAt(i));
            }

        }

        private void AddActorButton_Click(object sender, EventArgs e)
        {
            if (ActorsComboBox.Text.Trim().Length > 0)
            {
                if (ActorsComboBox.Items.Contains(ActorsComboBox.Text.Trim()) == false)
                {
                    ActorsComboBox.Items.Add(ActorsComboBox.Text.Trim());
                    ActorsComboBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Actor already in the list");
                }

            }
        }

        private void AddGenreButton_Click(object sender, EventArgs e)
        {
            if (GenresComboBox.Text.Trim().Length > 0)
            {
                if (GenresComboBox.Items.Contains(GenresComboBox.Text.Trim()) == false)
                {
                    GenresComboBox.Items.Add(GenresComboBox.Text.Trim());
                    GenresComboBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Genre already in the list");
                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Boolean verified;
            Movie newMovie;

            verified = VerifyData();

            if (verified == true)
            {
                newMovie = CreateMovie();

                if ( this.Text == "Add Movie")
                {
                    if( Program.CheckTitleAvailable(newMovie.Title) ==  true)
                    {
                        Program.UpdateMovieDataBase(newMovie, null);

                        sentBy.Close();
                        MovieForm viewMovie = new MovieForm();
                        viewMovie.FillForm(newMovie);
                        viewMovie.Show();
                        this.Close();

                    } else
                    {
                        MessageBox.Show("Movie title already in use");
                    }
                } else
                {
                    Program.UpdateMovieDataBase(newMovie, editingMovie);

                    returnMovie.Invalidate();
                    returnMovie.Refresh(newMovie);
                    returnMovie.Show();
                    this.Close();
                }
            } 
           
        }

        private Boolean VerifyData()
        {
            Boolean verified = false;

            if (titleTextBox.Text.Trim().Length > 0)
            {
                if (ActorsComboBox.Items.Count > 0)
                {
                    if (DirectorTextBox.Text.Trim().Length > 0)
                    {
                        if (ValidRating())
                        {
                            if (GenresComboBox.Items.Count > 0)
                            {
                                if (ValidYear() )
                                {
                                    if( LengthTextBox.Text.Trim().Length > 0 )
                                    {
                                        verified = true;

                                    } else
                                    {
                                        MessageBox.Show("Movie requires a length");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Year of creation can only be 4 digits");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Movie requires atleast one genre");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Rating must be an number ranging between 0 and 10");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Movie requires a director");
                    }
                }
                else
                {
                    MessageBox.Show("Movie requires atleast one actor");
                }
            }
            else
            {
                MessageBox.Show("Movie required a title");
            }

            return verified;
        }

        private Boolean ValidRating()
        {
            Boolean Valid = false;
            int attempt;
            Boolean isADigit;

            isADigit = int.TryParse(RatingTextBox.Text.Trim(), out attempt);

            if (isADigit == true)
            {
                if (attempt >= 0 && attempt <= 10)
                {
                    Valid = true;
                }
            }

            return Valid;
        }

        private Boolean ValidYear()
        {
            Boolean valid = false;

            if (YoCTextBox.Text.Trim().Length == 4)
            {
                if (YoCTextBox.Text.All(char.IsDigit))
                {
                    valid = true;
                }
            }

            return valid;
        }

        private Movie CreateMovie()
        {
            Movie movie;
            String title = titleTextBox.Text.Trim();
            String director = DirectorTextBox.Text.Trim();
            String rating = RatingTextBox.Text.Trim();
            String year = YoCTextBox.Text.Trim();
            String length = LengthTextBox.Text.Trim();
            int totalActors = ActorsComboBox.Items.Count;
            int totalGenres = GenresComboBox.Items.Count;
            List<String> actors = new List<String>();
            List<String> genres = new List<String>();

            for (int i = 0; i < totalActors; i++)
            {
                actors.Add(ActorsComboBox.Items[i].ToString());
            }

            for(int i = 0; i < totalGenres; i++)
            {
                genres.Add(GenresComboBox.Items[i].ToString());
            }

            movie = new Movie(title, year, rating, actors, director, genres, length);

            return movie;
        }

        private void deleteMovieButton_Click(object sender, EventArgs e)
        {
            VerifyDelete verify = new VerifyDelete(this);
            verify.Show();
        }

        public void Delete()
        {
            Program.UpdateMovieDataBase(null, editingMovie);
            sentBy.Close();
            SearchForm search = new SearchForm();
            search.Location = this.Location;
            search.Show();
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

        private void manageCollectionLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ManageCollectionForm manageCollection = new ManageCollectionForm();
            manageCollection.Location = this.Location;
            manageCollection.Size = this.Size;
            manageCollection.Show();
            this.Close();
        }

        private void ActorsComboBox_Enter(object sender, EventArgs e)
        {
            ActorsComboBox.Text = "";
        }

        private void GenresComboBox_Enter(object sender, EventArgs e)
        {
            GenresComboBox.Text = "";
        }

        private void DeleteActor_Click(object sender, EventArgs e)
        {
            if( ActorsComboBox.SelectedItem != null)
            {
                ActorsComboBox.Items.Remove(ActorsComboBox.SelectedItem);
            }

            ActorsComboBox.Text = "";
        }

        private void DeleteGenre_Click(object sender, EventArgs e)
        {
            if( GenresComboBox.SelectedItem != null)
            {
                GenresComboBox.Items.Remove(GenresComboBox.SelectedItem);
            }

            GenresComboBox.Text = "";
        }

        private void EditMovieForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == Convert.ToChar(Keys.Enter)) {
                SubmitButton_Click(this, e);
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Location = this.Location;
            login.Show();
            this.Close();
        }
    } 
}
