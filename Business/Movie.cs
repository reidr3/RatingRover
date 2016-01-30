using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RatingRover.Business
{
    public class Movie
    {
        private string title;
        private string yearReleased;
        private string rating;
        private List<string> actors = new List<string>();
        private string director;
        private List<string> genres = new List<string>();
        private string runningTime;
        private string userRatings;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string YearReleased
        {
            get
            {
                return yearReleased;
            }

            set
            {
                yearReleased = value;
            }
        }

        public string Rating
        {
            get
            {
                return rating;
            }

            set
            {
                rating = value;
            }
        }

        public string Director
        {
            get
            {
                return director;
            }

            set
            {
                director = value;
            }
        }

        public string RunningTime
        {
            get
            {
                return runningTime;
            }

            set
            {
                runningTime = value;
            }
        }

        public string UserRatings
        {
            get
            {
                return userRatings;
            }

            set
            {
                userRatings = value;
            }
        }

        public Movie(string title, string yearReleased, string userRating, List<string> actors, string director, List<string> genres, string runningTime)
        {
            this.title = title;
            this.yearReleased = yearReleased;
            this.rating = userRating;
            this.actors = actors.ToList();
            this.director = director;
            this.genres = genres.ToList();
            this.runningTime = runningTime;
            this.userRatings = null;
        }

        public void AddActor(string actor)
        {
            if (this.actors.Contains(actor) == false)
            {
                actors.Add(actor);
            }

        }

        public Boolean RemoveActor(string actor)
        {
            Boolean removed = false;

            if (this.actors.Contains(actor))
            {
                actors.Remove(actor);
                removed = true;
            }

            return removed;
        }

        public void AddGenre(string genre)
        {
            if (this.genres.Contains(genre) == false)
            {
                this.genres.Add(genre);
            }

        }

        public Boolean RemoveGenre(string genre)
        {
            Boolean removed = false;

            if (genres.Contains(genre))
            {
                genres.Remove(genre);
                removed = true;
            }

            return removed;
        }

        public ListViewItem ToListViewItem()
        {
            ListViewItem movieItem = new ListViewItem();

            movieItem.Text = title;
            movieItem.Tag = this;

            return movieItem;
        }

        public int TotalActors()
        {
            return actors.Count;
        }

        public int TotalGenres()
        {
            return genres.Count;
        }

        public List<String> GetActors()
        {
            return actors;
        }

        public List<String> GetGenres()
        {
            return genres;
        }

        public void Replace(Movie newMovie)
        {
            title = newMovie.Title;
            yearReleased = newMovie.yearReleased;
            rating = newMovie.rating;
            director = newMovie.director;
            runningTime = newMovie.runningTime;
            userRatings = newMovie.userRatings;
            actors = newMovie.GetActors().ToList();
            genres = newMovie.GetGenres().ToList();
        }
    }
}
