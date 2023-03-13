namespace BibliothekAPI
{
    public class Book : Medium
    {
        public string Author { get; set; }
        public int SizeOfPages { get; set; }

        public Book(int id, string title, string author, int sizeOfPages, string description, string type, double cost) : base(id, title, description, type, cost)
        {
            Author = author;
            SizeOfPages = sizeOfPages;
        }
    }
}
