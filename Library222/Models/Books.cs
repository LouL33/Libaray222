using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library222.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public bool IsCheckedOut { get; set; }
        public DateTime? LastChechedOut { get; set; }
        public DateTime? DueBackDate { get; set; }
    }
}