using Microsoft.AspNetCore.Mvc;
using Biblio.Api.Models.Requests;

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
        public void Post(CreateBookRequest creatBookRequest)
        { }
    }
}