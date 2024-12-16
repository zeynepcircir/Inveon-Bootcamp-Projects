using AutoMapper;
using LibraryManagement.Core.DTOs;
using LibraryManagement.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.API.Controllers
{
    public class BooksController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IBookService _service;

        public BooksController(IMapper mapper, IBookService productService)
        {
            _mapper = mapper;
            _service = productService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var products = await _service.GetAllAsync();
            var productsDtos = _mapper.Map<List<BookListDTO>>(products.ToList());
            return CreateActionResult(CustomResponseDTO<List<BookListDTO>>.Success(200, productsDtos));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _service.GetByIdAsync(id);
            var productDto = _mapper.Map<BookDetailsDTO>(product);
            return CreateActionResult(CustomResponseDTO<BookDetailsDTO>.Success(200, productDto));
        }
    }
}
