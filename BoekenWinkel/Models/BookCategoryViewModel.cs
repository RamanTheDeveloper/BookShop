using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoekenWinkel.Models
{
    public class BookCategoryViewModel
    {
        public List<Book> Books { get; set; }
        public int? BookCategory { get; set; }
        public string SearchString { get; set; }
    }
}
