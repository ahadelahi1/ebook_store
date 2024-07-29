namespace Eproject_Online_Book_Store.Models
{
    public class Books
    {
        public int Id { get; set; }

        public string Book_Name { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

       public string PublishYear { get; set; }

        public string Book_Image { get; set; }

        public Books(int id, string book_Name, string description, string author, string publishYear, string book_Image)
        {
            Id = id;
            Book_Name = book_Name;
            Description = description;
            Author = author;
            PublishYear = publishYear;
            Book_Image = book_Image;
        }
    }
}
