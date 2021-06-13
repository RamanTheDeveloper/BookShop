using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoekenWinkel.Models
{
    public class BookModel
    {
        [Required]
        public string BookTitle { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int ISBN { get; set; }

        public int BookTypeId { get; set; }
        public IEnumerable<BookType> BookTypes { get; set; }
    }

}
