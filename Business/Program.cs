using RatingRover.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace RatingRover
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static List<Movie> movieList = new List<Movie>();
        public static List<Movie> watchList = new List<Movie>();
        public static List<Movie> recommendationList = new List<Movie>();
        private static String loggedInUser;

        [STAThread]
        static void Main()
        {
            LoadDatabase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

        }

        private static void LoadDatabase()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Resources/movies.xml");
            int count = 0;


            if( doc != null )
            {
                XmlNodeList movieList = doc.GetElementsByTagName("movie");

                foreach( XmlNode item in movieList )
                {
                    AddToList(item, Program.movieList);
                    count++;
                }
            }
        }

        public static List<Movie> getMovieList()
        {
            return movieList;
        }


        private static void LoadWatchList(XmlNode userNode)
        {
            XmlNodeList userMovieList;
            int movies = movieList.Count;
            userNode = userNode.SelectSingleNode("watchlist");
            watchList.Clear();
            String currentTitle;

            if(userNode != null && userNode.HasChildNodes == true )
            {
                userMovieList = userNode.ChildNodes;

                foreach(XmlNode node in userMovieList)
                {
                    if( node.Name == "movie")
                    {
                        currentTitle = node.SelectSingleNode("title").InnerText.Trim();

                        for (int i = 0; i < movies; i ++)
                        {

                            if( movieList.ElementAt(i).Title == currentTitle )
                            {
                                watchList.Add(movieList.ElementAt(i));
                            }
                        }
                    }
                }
            }

        }

        public static Boolean OpenUserName(String username)
        {
            Boolean open = true;
            String currentUserName;
            XmlDocument doc = new XmlDocument();
            doc.Load("Resources/users.xml");
            XmlNodeList users = doc.GetElementsByTagName("user");

            foreach (XmlNode user in users)
            {
                currentUserName = user.SelectSingleNode("username").InnerText;

                if (currentUserName.Equals(username))
                {
                    open = false;
                    break;
                }

            }

            return open;
        }

        public static void CreateUser(String userName, String password)
        {

            XDocument doc = XDocument.Load("Resources/users.xml");
            XElement root = doc.Element("users");

            root.Add(
                new XElement("user",
                new XElement("username", userName),
                new XElement("password", password),
                new XElement("watchlist", "")));

            doc.Save("Resources/users.xml");
        }

        public static Boolean Login(String username, String password)
        {
            Boolean match = false;
            String currentUsername = "";
            String currentPassword = "";
            XmlDocument doc = new XmlDocument();
            doc.Load("Resources/users.xml");

            XmlNodeList userList = doc.GetElementsByTagName("user");

            foreach(XmlNode user in userList)
            {
                currentUsername = user.SelectSingleNode("username").InnerText;
                currentPassword = user.SelectSingleNode("password").InnerText;

                if( currentPassword == password && currentUsername == username )
                {
                    match = true;
                    LoadWatchList(user);
                    loggedInUser = username;
                    break;
                    
                }
            }

            return match;
        }

        private static void AddToList(XmlNode itemToAdd, List<Movie> listToAdd)
        {
            Movie newMovie;
            String currentTitle;
            String currentYear;
            String currentLength;
            String Director;
            String userRatings;
            List<String> currentActors = new List<String>();
            List<String> genres = new List<String>();
            XmlNode iteratorNode;

            currentTitle = itemToAdd.SelectSingleNode("title").InnerText.Trim();
            currentYear = itemToAdd.SelectSingleNode("year").InnerText.Trim();
            currentLength = itemToAdd.SelectSingleNode("length").InnerText.Trim();
            Director = itemToAdd.SelectSingleNode("director").InnerText.Trim();
            userRatings = itemToAdd.SelectSingleNode("rating").InnerText.Trim();

            iteratorNode = itemToAdd.SelectSingleNode("genre");

            while(iteratorNode != null && iteratorNode.Name == "genre" )
            {
                genres.Add(iteratorNode.InnerText.Trim());
                iteratorNode = iteratorNode.NextSibling;
            }

            iteratorNode = itemToAdd.SelectSingleNode("actor");

            while( iteratorNode != null && iteratorNode.Name == "actor" )
            {
                currentActors.Add(iteratorNode.InnerText.Trim());
                iteratorNode = iteratorNode.NextSibling;
            }

            newMovie = new Movie(currentTitle, currentYear, userRatings, currentActors, Director, genres, currentLength);
            listToAdd.Add(newMovie);
        }

        public static void FillListView(ListView listView)
        {
            ListViewItem temp = new ListViewItem();
            List<Movie> recList = new List<Movie>();
            int columns = listView.Columns.Count;
            int items = movieList.Count;
            int count = 0;
            int itemIndex = 0;
            String rating;
            Random rnd = new Random();

            while( count < 50 )
            {
                itemIndex = rnd.Next(items);
                if(listView.Items.ContainsKey(movieList.ElementAt(itemIndex).Title) == false)
                {
                    rating = movieList.ElementAt(itemIndex).Rating;
                    if(rating.CompareTo("8") >= 0 && recommendationList.Contains(movieList.ElementAt(itemIndex)) == false ) {
                        temp = new ListViewItem(movieList.ElementAt(itemIndex).Title);
                        temp.ImageKey = temp.Text;
                        temp.Tag = movieList.ElementAt(itemIndex);
                        listView.Items.Add(temp);
                        recList.Add(movieList.ElementAt(itemIndex));
                        count++;
                    }
                }
            }

            recommendationList = recList;
        }

        public static void UpdateWatchList()
        {
            String currentUsername;

            int actors;
            int genres;
            int movies = watchList.Count;
            XmlDocument doc = new XmlDocument();
            XmlNodeList users;
            XmlNode watchListRoot;
            XmlElement createdElement;
            XmlElement movieRoot;
            List<String> currentActors;
            List<String> currentGenres;
            doc.Load("Resources/users.xml");

            users = doc.GetElementsByTagName("user");

            foreach (XmlNode user in users)
            {
                currentUsername = user.SelectSingleNode("username").InnerText;

                if( currentUsername == loggedInUser)
                {
                    watchListRoot = user.SelectSingleNode("watchlist");
                    watchListRoot.RemoveAll();
                    
                    if( movies == 0 )
                    {
                        watchListRoot.RemoveAll();
                        doc.Save("Resources/users.xml");
                        break;
                    }

                    for(int i = 0; i < movies; i++)
                    {
                        movieRoot = doc.CreateElement("movie");

                        createdElement = doc.CreateElement("title");
                        createdElement.InnerText = watchList.ElementAt(i).Title;
                        movieRoot.PrependChild(createdElement);

                        createdElement = doc.CreateElement("director");
                        createdElement.InnerText = watchList.ElementAt(i).Director;
                        movieRoot.PrependChild(createdElement);

                        createdElement = doc.CreateElement("rating");
                        createdElement.InnerText = watchList.ElementAt(i).Rating;
                        movieRoot.PrependChild(createdElement);

                        createdElement = doc.CreateElement("year");
                        createdElement.InnerText = watchList.ElementAt(i).YearReleased;
                        movieRoot.PrependChild(createdElement);

                        createdElement = doc.CreateElement("length");
                        createdElement.InnerText = watchList.ElementAt(i).RunningTime;
                        movieRoot.PrependChild(createdElement);

                        actors = watchList.ElementAt(i).TotalActors();
                        currentActors = watchList.ElementAt(i).GetActors();

                        for (int j = 0; j < actors; j++)
                        {
                            createdElement = doc.CreateElement("actor");
                            createdElement.InnerText = currentActors.ElementAt(j).ToString();
                            movieRoot.PrependChild(createdElement);
                        }

                        genres = watchList.ElementAt(i).TotalGenres();
                        currentGenres = watchList.ElementAt(i).GetGenres();

                        for (int j = 0; j < genres; j++)
                        {
                            createdElement = doc.CreateElement("genre");
                            createdElement.InnerText = currentGenres.ElementAt(j).ToString();
                            movieRoot.PrependChild(createdElement);
                        }

                        watchListRoot.PrependChild(movieRoot);
                        doc.Save("Resources/users.xml");
                    }

                    break;
                }
            }

        }

        public static void UpdateMovieDataBase(Movie newMovie, Movie oldMovie)
        {
            int index;
            if (newMovie != null)
            {
                if (oldMovie != null)
                {
                    //Rewrite old movie in XML
                    //Replace movie in movielist with new movie
                    int indexOfMovie = 0;
                    if(recommendationList.Contains(oldMovie))
                    {
                        indexOfMovie = recommendationList.IndexOf(oldMovie);
                        recommendationList.Remove(oldMovie);
                        recommendationList.Insert(indexOfMovie, newMovie);
                    }

                    if (watchList.Contains(oldMovie))
                    {
                        indexOfMovie = watchList.IndexOf(oldMovie);
                        watchList.Remove(oldMovie);
                        watchList.Insert(indexOfMovie,newMovie);
                    }

                    RewriteMovie(newMovie, oldMovie);
                    index = movieList.IndexOf(oldMovie);
                    movieList.ElementAt(index).Replace(newMovie);
                }
                else
                {
                    //Write movie to XML
                    //Add it to movieList
                    AddMovie(newMovie);
                    movieList.Add(newMovie);
                }
            } else
            {
                if( oldMovie != null)
                {
                    //Delete the movie from XML
                    //Remove it from movie list
                    DeleteMovie(oldMovie);
                    movieList.Remove(oldMovie);

                    recommendationList.Remove(oldMovie);
                    watchList.Remove(oldMovie);
                }
            }
        }

        private static void RewriteMovie(Movie newMovie, Movie oldMovie)
        {
            DeleteMovie(oldMovie);
            AddMovie(newMovie);
        }

        private static void AddMovie(Movie newMovie)
        {
            XDocument doc = XDocument.Load("Resources/movies.xml");
            XElement root = doc.Element("movielist");

            root.AddFirst(
                new XElement("movie", ""));


            root = root.Element("movie");

            WriteMovie(root, newMovie);

            doc.Save("Resources/movies.xml");

        }

        private static void DeleteMovie(Movie oldMovie)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Resources/movies.xml");
            XmlNodeList movieList = doc.GetElementsByTagName("movie");
            String currentTitle;
            XmlNode parent;

            foreach(XmlNode movie in movieList)
            {
                currentTitle = movie.SelectSingleNode("title").InnerText.Trim();

                if(currentTitle == oldMovie.Title.Trim())
                {
                    movie.RemoveAll();
                    parent = movie.ParentNode;
                    parent.RemoveChild(movie);
                    doc.Save("Resources/movies.xml");
                    break;
                }
            }
            
        }

        public static Boolean CheckTitleAvailable(String title)
        {
            Boolean available = true;
            XmlDocument doc = new XmlDocument();
            doc.Load("Resources/movies.xml");
            XmlNodeList movieList = doc.GetElementsByTagName("movie");
            String currentTitle;

            foreach( XmlNode movie in movieList)
            {
                currentTitle = movie.SelectSingleNode("title").InnerText.Trim();

                if(currentTitle == title)
                {
                    available = false;
                    break;
                }
            }
            return available;
        }

        private static void WriteMovie(XElement root, Movie movie)
        {
            int actors = movie.TotalActors();
            int genres = movie.TotalGenres();
            List<String> actorList = movie.GetActors();
            List<String> genreList = movie.GetGenres();


            root.Add(
                new XElement("title", movie.Title));

            root.Add(
                new XElement("year", movie.YearReleased));

            root.Add(
                new XElement("length", movie.RunningTime));

            root.Add(
                new XElement("director", movie.Director));

            root.Add(
                new XElement("rating", movie.Rating));

            for(int i = 0; i < actors; i++)
            {
                root.Add(
                    new XElement("actor", actorList.ElementAt(i)));
            }

            for(int i = 0; i < genres; i++)
            {
                root.Add(
                    new XElement("genre", genreList.ElementAt(i)));
            }

        }
    }
}
