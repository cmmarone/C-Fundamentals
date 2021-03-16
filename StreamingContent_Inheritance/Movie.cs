using RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Inheritance
{
    public class Movie:StreamingContent
    {

        //we get all of the properties from a streaming content b/c a movie "is a" streaming content.
        public double RunTime { get; set; }

        public Movie()
        {

        }

        public Movie(string title, string description, MaturityRating maturityRating, GenreType genreType, double starRating, double runTime)
            :base(title,description,maturityRating,genreType,starRating)  //just refer to the base class and use those values
        {
            RunTime = runTime;
        }
    }
}
