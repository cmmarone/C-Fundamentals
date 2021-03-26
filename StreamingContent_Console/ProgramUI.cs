
using RepositoryPattern;
using StreamingContent_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Console
{
    public class ProgramUI
    {
        private readonly StreamingRepository _streamingRepo = new StreamingRepository(); //creating a new StreamingRepository, called _streamingRepo
        public void Run()
        {
            SeedContentList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true; //this setup keeps
            while (continueToRun)       //the while loop running all the time
            {
                Console.Clear();

                Console.WriteLine("Enter the number of the option you would like to select:\n" +
                    "1: Show all streaming content\n" +
                    "2: Find streaming content by title\n" +
                    "3: Add new streaming content\n" +
                    "4: Remove streaming content\n" +
                    "5: Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ShowAllContent();
                        break;
                    case "2":
                        ShowContentByTitle();
                        break;
                    case "3":
                        CreateNewContent();
                        break;
                    case "4":
                        RemoveContentFromList();
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 5\n" + "Press any key to continue...");
                        Console.ReadKey();
                        break;

                }

            }
        }

        private void CreateNewContent()
        {
            Console.Clear(); //gives the user a fresh console to work with

            StreamingContent content = new StreamingContent();

            Console.WriteLine("Welcome to your Streaming Content Creator Page!!");

            Console.WriteLine("Please enter a title:");
            content.Title = Console.ReadLine();

            Console.WriteLine("Please enter a description:");
            content.Description = Console.ReadLine();

            Console.WriteLine("Please enter a star rating (1-5):");
            content.StarRating = double.Parse(Console.ReadLine()); //C.RL takes in a string.  prop StarRating was defined as double, so we need to take in the string and make it a double so it can be stored as StarRating
                                                                   //there's more than one way to do this, but Parse is good b/c it is seeking out a number.

            Console.WriteLine("Select a Maturity Rating:\n" +
                "1: G\n" +
                "2: PG\n" +
                "3: PG-13\n" +
                "4: R\n" +
                "5: NC-17\n" +
                "6: TV-Y\n" +          //we don't have to keep them in order of the enum if we're mapping with a switch case (like below)
                "7: TV-G\n" +
                "8: TV-PG\n" +
                "9: TV-14\n" +
                "10: TV-MA\n");
            string maturityInput = Console.ReadLine();

            switch (maturityInput)
            {
                case "1":
                    content.MaturityRating = MaturityRating.G;
                    break;
                case "2":
                    content.MaturityRating = MaturityRating.PG;
                    break;
                case "3":
                    content.MaturityRating = MaturityRating.PG_13;
                    break;
                case "4":
                    content.MaturityRating = MaturityRating.R;
                    break;
                case "5":
                    content.MaturityRating = MaturityRating.NC_17;
                    break;
                case "6":
                    content.MaturityRating = MaturityRating.TV_Y;
                    break;
                case "7":
                    content.MaturityRating = MaturityRating.TV_G;
                    break;
                case "8":
                    content.MaturityRating = MaturityRating.TV_PG;
                    break;
                case "9":
                    content.MaturityRating = MaturityRating.TV_14;
                    break;
                case "10":
                    content.MaturityRating = MaturityRating.TV_MA;
                    break;


                    //we don't have a solution to get them back to selecting maturity rating if they input wrong. We're just not skilled enough yet
            }

            Console.WriteLine("Please select a Genre Type by it's corresponding number:\n" +
                "1: Horror\n" +
                "2: RomCom\n" +
                "3: SciFi\n" +
                "4: Documentary\n" +
                "5: Bromance\n" +
                "6: Drama\n" +
                "7: Action\n");
            string genreInput = Console.ReadLine();

            int genreID = int.Parse(genreInput);              // we automatically pull the enum index b/c we prompted in the order of the enum (the enum index started with 1 in that case)

            content.GenreType = (GenreType)genreID;


            //now we're adding all of that content to the directory

            _streamingRepo.AddContentToDirectory(content);     //that method is actually in StreamingContentRepository



        }
        private void ShowAllContent()
        {
            Console.Clear(); // give user fresh page to work with

            List<StreamingContent> listOfContent = _streamingRepo.GetContents();
            foreach (StreamingContent content in listOfContent)
            {
                DisplayContent(content);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void ShowContentByTitle()
        {
            Console.Clear(); // give user a fresh page to work with
            Console.WriteLine("Please enter a Title:");
            string title = Console.ReadLine();
            StreamingContent content = _streamingRepo.GetContentByTitle(title);
            if (content != null)
            {
                DisplayContent(content);
            }
            else
            {
                Console.WriteLine($"Invalid Title. Could not find result {title}");
            }
            Console.WriteLine("Press any key to continue.......");
            Console.ReadKey();

        }



        private void RemoveContentFromList()
        {
            Console.Clear();
            Console.WriteLine("Which item would you like to remove?");
            List<StreamingContent> contentList = _streamingRepo.GetContents();
            int count = 0; //start at index 0
            foreach (StreamingContent content in contentList)
            {
                count++;
                Console.WriteLine($"{count}. {content.Title}");
            }

            int targetContentID = int.Parse(Console.ReadLine());
            int targetIndex = targetContentID - 1;

            if (targetIndex >= 0 && targetIndex < contentList.Count)
            {
                StreamingContent desiredContent = contentList[targetIndex]; //square brackets always target an index value for any kind of collection
                if (_streamingRepo.DeleteExistingContent(desiredContent))
                {
                    Console.WriteLine($"{desiredContent.Title} was successfully removed.");
                }
                else
                {
                    Console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that.");
                }
            }
            else
            {
                Console.WriteLine("No content has that ID.");
            }
            Console.WriteLine("Press any key to continue...............");
            Console.ReadKey();
        }




        private void DisplayContent(StreamingContent content) // this is a helper method to feed into ShowAllContent() and ShowContentByTitle()
        {
            Console.WriteLine($"Title: {content.Title}\n" +     //adam likes to put his helper methods all the way at the bottom, before seeding
            $"Description: {content.Description}\n" +
            $"Star Rating: {content.StarRating}\n" +
            $"Maturity Rating: {content.MaturityRating}\n" +
            $"Is Family Friendly: {content.IsFamilyFriendly}\n" +
            $"Genre: {content.GenreType}\n");


        }

        private void SeedContentList()
        {
            StreamingContent rubber = new StreamingContent("Rubber", "Tire comes to life and kills people", MaturityRating.R, GenreType.Drama, 5.8d);
            StreamingContent toystory = new StreamingContent("TOy Story", "Best childhood", MaturityRating.G, GenreType.Bromance, 10.0d);
            StreamingContent starwars = new StreamingContent("Star Wars", "Jar Jar saves the world", MaturityRating.PG_13, GenreType.SciFi, 9.2);

            _streamingRepo.AddContentToDirectory(rubber);  //actually adding to directory
            _streamingRepo.AddContentToDirectory(toystory);
            _streamingRepo.AddContentToDirectory(starwars);

        }

    }
}
