using AutoMapper;
using LibraryManagement.Core.DTOs;
using LibraryManagement.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBookService _bookService;

        public BookController(IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var books = await _bookService.GetAllAsync();

            var bookListDTOs = _mapper.Map<List<BookListDTO>>(books);

            return View(bookListDTOs);
        }

        [HttpGet("Book/Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var book = await _bookService.GetByIdAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            var bookDetailsDTO = _mapper.Map<BookDetailsDTO>(book);

            return View(bookDetailsDTO);
        }
    }
}
