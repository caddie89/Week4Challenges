using _06_RepositoryPattern_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console
{
    class ProgramUI
    {
        private StreamingContentRepository _contentRepo = new StreamingContentRepository();             //This will not go away until the console has been closed

        //Method that runs/starts the application - that's why we're calling it "Run"
        public void Run()                                       //Entry into the class - we need someone to be able to call this run method
        {
            SeedContentList();
            Menu();
        }

        //Menu method
        private void Menu()                                     //No way to call this in the Main program
        {
            bool keepRunning = true;
            while (keepRunning)
            { 
                // Display our options to the user
                Console.WriteLine("Please select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

            // Get the user's input
            string input = Console.ReadLine();

            // Evaluate the user's input and act accordingly
            switch (input)
            {
                case "1":
                    //Create New Content
                    CreateNewContent();
                    break;
                case "2":
                    //View All Content
                    DisplayAllContent();
                    break;
                case "3":
                    //View Content By Title
                    DisplayContentByTitle();
                    break;
                case "4":
                    //Update Existing Content
                    UpdateExistingContent();
                    break;
                case "5":
                    //Delete Existing Content
                    DeleteExistingContent();
                    break;
                case "6":
                    //Exit
                    Console.WriteLine("Goodbye!");
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid number option (like 1, 2, 3, etc.).");
                    break;
            }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        //Create new StreamingContent
        private void CreateNewContent()
        {
            Console.Clear();

            StreamingContent newContent = new StreamingContent();

            //Title

            Console.WriteLine("Enter the title for the content:");
            newContent.Title = Console.ReadLine();

            //Description

            Console.WriteLine("Enter the description for the content:");
            newContent.Description = Console.ReadLine();

            //Maturity Rating

            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, R, M):");
            newContent.MaturityRating = Console.ReadLine();

            //Star Rating

            Console.WriteLine("Enter the star count for the content (5.8, 10, 1.5):");
            string starAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starAsString);

            //IsFamilyFriendly

            Console.WriteLine("Is this content family friendy? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();

            if (familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            //GenreType

            Console.WriteLine("Enter the Genre Number:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Drama\n" +
                "6. Action\n" +
                "7. Comedy\n" +
                "8. War\n" +
                "9. Family\n");

            //1 Getting user input and saving it as a string
            string genreAsString = Console.ReadLine();      
            //2 parse it, turn it into a number
            int genreAsInt = int.Parse(genreAsString);
            //3 cast to turn that number into a genretype
            newContent.TypeOfGenre = (GenreType)genreAsInt;                                        //CASTING

            _contentRepo.AddContentToList(newContent);

            /*
                Horror = 1,                             //No longer zero indexed
                RomCom = 2,
                SciFi = 3,
                Documentary = 4, 
                Drama = 5,
                Action = 6,
                Comedy = 7,
                War = 8,
                Family = 9
             */
        }

        private StreamingContent StreamingContent()
        {
            throw new NotImplementedException();
        }

        //View Current StreamingContent that is saved

        private void DisplayAllContent()
        {
            Console.Clear();

            List<StreamingContent> listOfContent = _contentRepo.GetContentList();

            foreach(StreamingContent content in listOfContent)
            {
                Console.WriteLine($"Title: {content.Title}\n" + 
                    $"Description: {content.Description}");
            }
        }

        //View existing Content by title

        private void DisplayContentByTitle()
        {
            Console.Clear();
            //Prompt the user to give me a title
            Console.WriteLine("Enter the title of the content you'd like to see:");

            //Get the user's input
            string title = Console.ReadLine();

            //Find the content by that title
            StreamingContent content = _contentRepo.GetContentByTitle(title);

            //Display said content if it isn't null
            if (content != null)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Description: {content.Description}\n" +
                    $"Maturity Rating: {content.MaturityRating}\n" +
                    $"Stars: {content.StarRating}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}\n" +
                    $"Genre: {content.TypeOfGenre}");
            }
            else
            {
                Console.WriteLine("No content by that title.");
            }

        }

        //Update Existing Content

        private void UpdateExistingContent()
        {
            //Display all content
            DisplayAllContent();

            //Ask for the title of the content to update
            Console.WriteLine("Enter the title of the content you'd like to update:");

            //Get that title
            string oldTitle = Console.ReadLine();

            //We will build a new object
            Console.Clear();

            StreamingContent newContent = new StreamingContent();

            //Title

            Console.WriteLine("Enter the title for the content:");
            newContent.Title = Console.ReadLine();

            //Description

            Console.WriteLine("Enter the description for the content:");
            newContent.Description = Console.ReadLine();

            //Maturity Rating

            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, R, M");
            newContent.MaturityRating = Console.ReadLine();

            //Star Rating

            Console.WriteLine("Enter the star count for the content (5.8, 10, 1.5):");
            string starAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starAsString);

            //IsFamilyFriendly

            Console.WriteLine("Is this content family friendy? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();

            if (familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            //GenreType

            Console.WriteLine("Enter the Genre Number:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Drama\n" +
                "6. Action\n" +
                "7. Comedy\n" +
                "8. War\n" +
                "9. Family\n");

            //1 Getting user input and saving it as a string
            string genreAsString = Console.ReadLine();
            //2 parse it, turn it into a number
            int genreAsInt = int.Parse(genreAsString);
            //3 cast to turn that number into a genretype
            newContent.TypeOfGenre = (GenreType)genreAsInt;                                        //CASTING

            //Verify the update worked
            bool wasUpdated =_contentRepo.UpdateExistingContent(oldTitle, newContent);

            if (wasUpdated)
            {
                Console.WriteLine("Content successfully update!");
            }
            else
            {
                Console.WriteLine("Could not update content.");
            }
        }

        //Delete Existing Content
        private void DeleteExistingContent()
        { 
            DisplayAllContent();

            // Get the title they want to remove
            Console.WriteLine("\nEnter the title of the content you'd like to remove:");

            string input = Console.ReadLine();

            //Call the delete method
            bool wasDeleted =_contentRepo.RemoveContentFromList(input);                             //If it was deleted, it will return true, if not, it will return false

            //If the content was deleted, say so
            //Otherwise state it could not be deleted
            if (wasDeleted)
            {
                Console.WriteLine("The content was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The content could not be deleted.");
            }

        }
        
        //See method
        private void SeedContentList()
        {
            StreamingContent sharknado = new StreamingContent("Sharknado", "Tornados, but with sharks.", "TV-14", 3.3, true, GenreType.Action);
            StreamingContent braveheart = new StreamingContent("Braveheart", "Some men die. Not every man really lives.", "R", 10, true, GenreType.War);
            StreamingContent whiteChristmas = new StreamingContent("White Christmas", "The best things happen while you're dancing.", "G", 10, true, GenreType.Family);

            _contentRepo.AddContentToList(sharknado);
            _contentRepo.AddContentToList(braveheart);
            _contentRepo.AddContentToList(whiteChristmas);

        }

      
    }
}
