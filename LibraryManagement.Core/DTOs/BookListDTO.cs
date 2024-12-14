﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Core.DTOs
{
    public class BookListDTO : BaseDto
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear  { get; set; }
        public string ISBN { get; set; }
    }
}
