using RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Inheritance
{
    public class StreamingRepository : StreamingContentRepository
    {
        //we will use the same _contentDirectory from StreamingContentRepository.cs 

        //read --> show
        public Show GetShowByTitle(string title)
        {
            //To find a specific show
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
                {
                    return (Show)content; //This cast changes the Type from a StreamingContent object to a Show object.

                }

            }
            return null;
        }

        //read --> movie
        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {                                                      //here, we used a shorter syntax to achieve the same thing we did with show
                if (content.Title.ToLower() == title.ToLower() && content is Movie)
                {
                    return (Movie)content; //This cast changes the Type from a StreamingContent object to a Movie object.

                }

            }
            return null;
        }


        //read get all

        public List<Show> GetAllShows()
        {    //use this to add our shows -->this is a "Newed-up" version of the list (we will return this list)
            List<Show> allShows = new List<Show>();

            foreach (StreamingContent content in _contentDirectory)
            {    //if the content that we find is of type Show...
                if (content is Show)
                {    //add the show to the allShows list
                    allShows.Add((Show)content);
                }
            }

            return allShows;
        }

        //read get all movies
        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();

            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie)
                {
                    allMovies.Add(content as Movie); //showing a different syntax to get the same result as if statement in GetAllShows()
                }
            }
            return allMovies;
        }

        //Challenges for the students to add from here:
        //get by other parameters
        //get by RunTime/AverageRunTime
        //Get Shows with over x episodes
        //Get Shows/Movie by rating



        //challenge - get show by avg run time
        public List<Show> GetShowByAvgRunTime(double averageRunTime)
        {
            List<Show> listOfShows = new List<Show>();
            foreach (Show content in _contentDirectory)
            {
                if (content.AverageRunTime == averageRunTime)
                {
                    listOfShows.Add(content);
                }

            }
            return listOfShows;
        }








        //trying challenge - get movie by run time
        public List<Movie> GetMovieByRunTime(double runTime)
        {
            List<Movie> listOfMovies = new List<Movie>();
            foreach (Movie content in _contentDirectory)
            {
                if (content.RunTime == runTime)
                {
                    listOfMovies.Add(content);
                }

            }
            return listOfMovies;
        }





        //get shows by star rating

        public List<Show> GetShowByStarRating(double starRating)
        {
            List<Show> listOfShows = new List<Show>();
            foreach (Show content in _contentDirectory)
            {
                if (content.StarRating == starRating)
                {
                    listOfShows.Add(content);
                }

            }
            return listOfShows;












        }
    }
}
