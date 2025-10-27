using Biblio.Common.Enums;

namespace Biblio.Common.Models.Requests
{
    public class CreateBookRequest
    {
        public string Title { get; set; }
        public BookGenre Genre { get; set; }
    }
}