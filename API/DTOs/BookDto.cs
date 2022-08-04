﻿using System.Collections.Generic;
using API.Entities;

namespace API.DTOs
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Rating { get; set; }
        public decimal ReviewsNumber { get; set; }
    }
}