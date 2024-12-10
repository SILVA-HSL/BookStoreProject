using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookStore.Application.Services;
using BookStore.Domain.Models;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookControllers : ControllerBase
    {

        private readonly IBookService _BookService;
        public BookControllers(IBookService bookService)
        {
            this._BookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(_BookService.getAllBooks());

        }

        [HttpGet("{id}")]
        public IActionResult GetBookById(Guid id)
        {
            return Ok(_BookService.getBookById(id));
        }

        [HttpPost]
        public IActionResult AddBook([FromBody] BookModel book)
        {
            return Ok(_BookService.addBook(book));
        }


        [HttpPut]
        public IActionResult UpdateBook([FromBody] BookModel book)
        {
            return Ok(_BookService.updateBook(book));
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteBook(Guid id)
        {
            _BookService.deleteBook(id);
            return Ok();
        }


    }
}
