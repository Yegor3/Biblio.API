using Biblio.Common.Enums;

namespace Biblio.Common.Entities
{
    public class Book
    {
        public String Title { get; set; }
        public String AuthorName { get; set; }
        public BookGenre Genre { get; set; }
    }
}

