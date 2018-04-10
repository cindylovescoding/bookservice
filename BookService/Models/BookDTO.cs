using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookService.Models
{
    public class BookDTO
    {
        public int Id { get; set; }
        public String Title { get; set;}
        public String AuthorName { get; set; }
    }
}