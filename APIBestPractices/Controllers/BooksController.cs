using APIBestPractices.Models;
using APIBestPractices.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIBestPractices.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "1984", Author = "George Orwell", Year = 1949 },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 }
        };

        private readonly CacheService _cacheService;

        public BooksController(CacheService cacheService)
        {
            _cacheService = cacheService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return Ok(books);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBookById(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound("Book not found.");
            return Ok(book);
        }

        [HttpPost]
        public ActionResult<Book> AddBook([FromBody] Book newBook)
        {
            newBook.Id = books.Max(b => b.Id) + 1;
            books.Add(newBook);
            return CreatedAtAction(nameof(GetBookById), new { id = newBook.Id }, newBook);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] Book updatedBook)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound("Book not found.");
            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.Year = updatedBook.Year;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound("Book not found.");
            books.Remove(book);
            return NoContent();
        }

        [HttpGet("paged")]
        public ActionResult<IEnumerable<Book>> GetBooksPaged(int pageNumber = 1, int pageSize = 5)
        {
            var pagedBooks = books.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return Ok(pagedBooks);
        }


        [HttpGet("cached/{id}")]
        public IActionResult GetBookByIdCached(int id)
        {
            var cacheKey = $"book:{id}";
            var cachedBook = _cacheService.GetCacheValue(cacheKey);

            if (!string.IsNullOrEmpty(cachedBook))
            {
                return Ok(System.Text.Json.JsonSerializer.Deserialize<Book>(cachedBook));
            }

            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound("Book not found.");

            _cacheService.SetCacheValue(cacheKey, System.Text.Json.JsonSerializer.Serialize(book));
            return Ok(book);
        }
    }
}
