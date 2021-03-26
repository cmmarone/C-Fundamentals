using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern

//When we create some StreamingContent objects later, we will be able to use this method to add it to our directory.




{
    public class StreamingContentRepository
    {                                              //_contentDIrectory is a field
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //create
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(content);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;                          //returns true if it was added
        }


        //read
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }


        //read or helper method b/c used throughout this repo
        //now let's get content by the title
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }

            return null;
        }

        public List<StreamingContent> GetContentByStarRating(double starRating)
        {
            List<StreamingContent> starRatingResults = new List<StreamingContent>();
           
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.StarRating == starRating)
                {
                    starRatingResults.Add(content);
                }
            
            }
            return starRatingResults;
        }

        public List<StreamingContent> GetContentByMaturityRating(MaturityRating maturityRating)
        {
            List<StreamingContent> maturityRatingResults = new List<StreamingContent>();

            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.MaturityRating == maturityRating)
                {
                    maturityRatingResults.Add(content);
                }

            }
            return maturityRatingResults;
        }

        public List<StreamingContent> GetContentByFamilyFriednly(bool isFamilyFriendly)
        {
            List<StreamingContent> familyFriendlyResults = new List<StreamingContent>();

            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.IsFamilyFriendly == isFamilyFriendly)
                {
                    familyFriendlyResults.Add(content);
                }
            }
            return familyFriendlyResults;
        }




        //update
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if (oldContent != null) //if oldContent is null, nothing will happen
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.GenreType = newContent.GenreType;
                oldContent.StarRating = newContent.StarRating;

                return true;
            }
            else
            {
                return false;
            }
        }

        //delete
        public bool DeleteExistingContent(StreamingContent existingContent)
        {

            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }

        //CHallenges for the students to add from here:
        //Get by other parameters...
        //Get by rating
        //Get by family friendly
        //Etc


    }
}
