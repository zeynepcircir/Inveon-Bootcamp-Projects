using AutoMapper;
using LibraryManagement.Core.Models;
using LibraryManagement.Core.Repositories;
using LibraryManagement.Core.Services;
using LibraryManagement.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service.Services
{
    public class BookService : Service<Book>, IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public BookService(
            IGenericRepository<Book> repository, IUnitOfWork unitOfWork,
            IMapper mapper, IBookRepository bookRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
        }
    }
}
