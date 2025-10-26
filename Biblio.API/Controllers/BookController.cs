using Microsoft.AspNetCore.Mvc;
using Biblio.Api.Models.Requests;
using Bibli.API.Models.Results;
using Biblio.Common.Entities;

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
        public CreateBookResult Post([FromBody] CreateBookRequest creatBookRequest)
        {
            return new CreateBookResult
            {
                BookId = 0
            };
        }

        [HttpGet("ById/(BookId)")]
        public Book Get([FromRoute] long BookId)
        {
            return new Book
            {
                BookId = 0
            };
        }

        [HttpPut]
        public bool Get([FromBody] Book book)
        {
            return true;
        }

        [HttpDelete("ById/(BookId)")]
        public bool Delete([FromRoute] long BookId)
        {
            return true;
        }
    }
}