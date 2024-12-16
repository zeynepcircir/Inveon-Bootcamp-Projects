using AutoMapper;
using LibraryManagement.Core.DTOs;
using LibraryManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Book, BookListDTO>().ReverseMap();
            CreateMap<Book, BookDetailsDTO>().ReverseMap();
        }
    }
}
