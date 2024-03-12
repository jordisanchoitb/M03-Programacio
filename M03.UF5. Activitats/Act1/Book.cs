using System;

namespace OOPEx
{
    public class Book : IComparable<Book>
    {
        const int ID = 1;
        const string TITLE = "Unknown";
        const int NUMPAGES = 10;
        public int Id { get; set; }
        public string? Title { get; set; }
        public int NumPages { get; set; }

        public Book(int id, string? title, int numPages)
        {
            Id = id;
            Title = title;
            NumPages = numPages;
        }

        public Book()
        {
            Id = ID;
            Title = TITLE;
            NumPages = NUMPAGES;
        }

        public override string ToString() => $"Book: Id: {Id}, Title: {Title}, NumPages: {NumPages}";

        public int CompareTo(Book? other) 
        {
            if (other == null) return 1;
            return this.NumPages.CompareTo(other.NumPages); 
        }
    }
}
