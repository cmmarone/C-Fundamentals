using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPattern;
using System;
using System.Collections.Generic;

namespace StreamingContentRepositoryTest
{
    [TestClass]
    public class UnitTest1
    {
        //so we want to test the add method in the repo
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //when testing, follow 3 A's--> Arrange, Act, Assert

            //Arrange --> overall setup
            StreamingContent content = new StreamingContent(); //we had to rightclick this assembly and add a reference. added RepositoryPattern. ctrl period clicked StreamingContent, using RepositoryPattern.
            StreamingContentRepository repository = new StreamingContentRepository();

            //Act --> Get/run code to test
            bool addResult = repository.AddContentToDirectory(content);

            //Assert --> Used to get the expected outcome of a test
            Assert.IsTrue(addResult); //Assert is a pre-built class designed to run the test and come back as successful nor not.  run the test and look for green check mark in test explorer


        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //remember AAA




            //Arrange --> initial setup

            //creating the content
            StreamingContent content = new StreamingContent();

            //creating the repo
            StreamingContentRepository repo = new StreamingContentRepository();

            //adding the repo content
            repo.AddContentToDirectory(content);




            //Act
            //our plan is to store the list of streaming content within a variable
            List<StreamingContent> listOfMovies = repo.GetContents();

            //looks through our entire list and returns true if there is content
            bool directoryHasContent = listOfMovies.Contains(content);



            //Assert
            Assert.IsTrue(directoryHasContent);


        }

        //we will start with private 'fields'
        private StreamingContentRepository _repo;
        private StreamingContent _content;


        //THIS IS THE ARRANGE PART...
        [TestInitialize]
        public void Arrange()
        {
            //we make a new movie here, finally.  We're inputting a movie now to use to test the various GetContentByXxxx methods.
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode", MaturityRating.R, GenreType.Drama, 5.8d);

            //now the movie is in our 'database' (list)
            _repo.AddContentToDirectory(_content);
        }

        //retrieve content by title
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange is already done above

            //Act
            StreamingContent searchResult = _repo.GetContentByTitle("Rubber");

            //Assert
            Assert.AreEqual(_content, searchResult);
        }

        //Test the update method
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange --> we want updated version of our movie. We're going to write over the original
            StreamingContent newContent = new StreamingContent("Rubber part 2", "A car tire comes to life with the power to make people explode", MaturityRating.R, GenreType.Drama, 9.8d);

            //Act
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);

            //Assert
            Assert.IsTrue(updateResult);

        }

        //Test the delete method
        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent content = _repo.GetContentByTitle("Rubber");

            //Act
            bool removeResult = _repo.DeleteExistingContent(content); //removeResult should return true if it worked

            //Assert
            Assert.IsTrue(removeResult); 
        }

    }
}
