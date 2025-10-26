using Microsoft.AspNetCore.Mvc;
using Biblio.Api.Models.Requests;
using Bibli.API.Models.Results;

namespace Biblio.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public CreateBookResult Post(CreateBookRequest creatBookRequest)
        {
            return new CreateBookResult
            {
                BookId = 0
            };
        }
    }
}