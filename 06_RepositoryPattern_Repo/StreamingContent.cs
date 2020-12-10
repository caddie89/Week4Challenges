using System;

namespace _06_RepositoryPattern_Repo
{
    public enum GenreType                       //enums all have numerical value behind the scenes
    {
        Horror = 1,                             //No longer zero indexed
        RomCom,
        SciFi,
        Documentary, 
        Drama,
        Action,
        Comedy,
        War,
        Family
    }

    //Plain Old C# Object - single responsibility object that just holds data

    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string MaturityRating { get; set; }
        public double StarRating { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public GenreType TypeOfGenre { get; set; }

        public StreamingContent() { }                       

        public StreamingContent(string title, string description, string maturityRating, double starRating, bool isFamilyFriendly, GenreType genre)
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            IsFamilyFriendly = isFamilyFriendly;
            TypeOfGenre = genre;
        }
    }
}
