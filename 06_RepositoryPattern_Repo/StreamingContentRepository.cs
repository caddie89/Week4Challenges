using System;
using System.Collections.Generic;
using System.Text;

namespace _06_RepositoryPattern_Repo
{
    public class StreamingContentRepository                             //Manipulate and hold data
    {
        private List<StreamingContent> _listOfContent = new List<StreamingContent>();           //Field (not a property) - variable in the class that can be used EVERYWHERE

        //Create                                      //1
        public void AddContentToList(StreamingContent content)          //These are doors or entryways into our class - this is a method with no return type
        {                     
            _listOfContent.Add(content);                                //Anything with an "_" is going to be a field - 1. Takes in from outside "content" (we don't know where yet), when the                                                                 method is called it has to be given a Streaming Content object, what is given is added to the list 
        }                                                               

        //Read
        public List<StreamingContent> GetContentList()                  //This method is getting the content list
        {
            return _listOfContent;
        }
                                                                            

        //Update
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            //Find the content
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            //Update the content
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.StarRating = newContent.StarRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;
                return true;
            }
            else
            {
                return false;
            }
        }


        //Delete
        public bool RemoveContentFromList(string title)                 //bool - either we removed the video or we didn't
        {
            StreamingContent content = GetContentByTitle(title);

            if (content == null)
            {
                return false;
            }

            int initialCount = _listOfContent.Count;
            _listOfContent.Remove(content);

            if(initialCount > _listOfContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper Method -- job is to help the other methods
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _listOfContent)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;                                 //Looking for a dvd, is this "Toy Story", no? I put it back, if I find it, I return it.
                }
            }

            return null;                                            //I have to give you something, but it's not what you're looking for
        }
    }
}
