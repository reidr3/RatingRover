using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingRover.Business
{
    class MovieFilter
    {
        private List<Movie> filterList;

        public MovieFilter(List<Movie> filterList)
        {
            this.filterList = filterList;
        }

        public MovieFilter()
        {
            this.filterList = Program.movieList.ToList();
        }

        public List<Movie> GetResult()
        {
            return filterList;
        }

        public void FilterTitle(String title)
        {
            int items = filterList.Count;

            if( title.Trim().Length > 0)
            {
                for (int i = 0; i < items; i++)
                {
                    if (filterList.ElementAt(i).Title.Contains(title) != true)
                    {
                        filterList.RemoveAt(i);
                        items--;
                        i--;
                    }
                }
            }
        }

        public void FilterActor(String actor)
        {
            int items = filterList.Count;
            int actors;
            Movie currentMovie;
            List<String> actorList;

            for (int i = 0; i < items; i++)
            {
                currentMovie = filterList.ElementAt(i);
                actorList = currentMovie.GetActors();
                actors = actorList.Count;
                
                for(int j = 0; j < actors; j++)
                {
                    if( actorList.ElementAt(j).Contains(actor))
                    {
                        break;
                    } 

                    if(j == actors - 1)
                    {
                        filterList.RemoveAt(i);
                        items--;
                        i--;
                    }
                }
            }
        }

        public void FilterDirector(String director)
        {
            int items = filterList.Count;

            for (int i = 0; i < items; i++)
            {
                if (filterList.ElementAt(i).Director.Contains(director) != true)
                {
                    filterList.RemoveAt(i);
                    items--;
                    i--;
                }
            }
        }

        public void FilterGenre(String genre)
        {
            int items = filterList.Count;
            int genreTotal;
            Movie currentMovie;
            List<String> GenreList;

            for (int i = 0; i < items; i++)
            {
                currentMovie = filterList.ElementAt(i);
                GenreList = currentMovie.GetGenres();
                genreTotal = GenreList.Count;

                for (int j = 0; j < genreTotal; j++)
                {
                    if (GenreList.ElementAt(j).Contains(genre))
                    {
                        break;
                    }

                    if (j == genreTotal - 1)
                    {
                        filterList.RemoveAt(i);
                        items--;
                        i--;
                    }
                }
            }
        }

        public void FilterMinRating(String rating)
        {
            int items = filterList.Count;

            for (int i = 0; i < items; i++)
            {
                if (Convert.ToInt32(filterList.ElementAt(i).Rating) < Convert.ToInt32(rating))
                {
                    filterList.RemoveAt(i);
                    items--;
                    i--;
                }
            }
        }

        public void FilterMaxRating(String rating)
        {
            int items = filterList.Count;

            for (int i = 0; i > items; i++)
            {
                if (Convert.ToInt32(filterList.ElementAt(i).Rating) > Convert.ToInt32(rating))
                {
                    filterList.RemoveAt(i);
                    items--;
                    i--;
                }
            }
        }


        public void FilterExactRating(int rating)
        {
            int items = filterList.Count;

            for (int i = 0; i < items; i++)
            {
                if (Convert.ToInt32(filterList.ElementAt(i).Rating)  == rating)
                {
                    filterList.RemoveAt(i);
                    items--;
                    i--;
                }
            }
        }

        public void FilterExactYear(int year)
        {
            int items = filterList.Count;

            for (int i = 0; i < items; i++)
            {
                if (Convert.ToInt32(filterList.ElementAt(i).YearReleased) != year)
                {
                    filterList.RemoveAt(i);
                    items--;
                    i--;
                }
            }
        }

        public void FilterMinYear(int year)
        {
            int items = filterList.Count;

            for (int i = 0; i < items; i++)
            {
                if (Convert.ToInt32(filterList.ElementAt(i).YearReleased) < year)
                {
                    filterList.RemoveAt(i);
                    items--;
                    i--;
                }
            }
        }

        public void FilterMaxYear(int year)
        {
            int items = filterList.Count;

            for (int i = 0; i < items; i++)
            {
                if (Convert.ToInt32(filterList.ElementAt(i).YearReleased) > year)
                {
                    filterList.RemoveAt(i);
                    items--;
                    i--;
                }
            }
        }

        public void SortTitle(Boolean Ascending)
        {
            if( Ascending == true )
            {
                filterList.Sort((p, q) => p.Title.CompareTo(q.Title));
            } else
            {
                filterList.Sort((p, q) => -1 * p.Title.CompareTo(q.Title));
            }
        }

        public void SortRating(Boolean Ascending)
        {
            if( Ascending == true)
            {
                filterList.Sort((p, q) => p.Rating.CompareTo(q.Rating));
            } else
            {
                filterList.Sort((p, q) => -1 * p.Rating.CompareTo(q.Rating));
            }
        }

        public void SortYear(Boolean Ascending)
        {
            if( Ascending == true )
            {
                filterList.Sort((p, q) => p.YearReleased.CompareTo(q.YearReleased));
            } else
            {
                filterList.Sort((p, q) => -1 * p.YearReleased.CompareTo(q.YearReleased));
            }
        }
    }
}
