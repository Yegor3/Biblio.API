using Biblio.Common.Enums;

namespace Biblio.Api.Models.Requests
{
    public class CreateBookRequest
    {
        public long BookId { get; set; }
        public string Title { get; set; }
        public BookGenre Genre { get; set; }
    }
}