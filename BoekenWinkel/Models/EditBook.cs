using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoekenWinkel.Models
{
    public class EditBook : EditBookBase
    {
        public EditBook() { }

        public EditBook(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            Author = book.Author;
            Description = book.Description;
            Price = book.Price;
            Isbn = book.Isbn;
        }

        public void Update(Book book)
        {
            book.Id = Id;
            book.Title = Title;
            book.Author = Author;
            book.Description = Description;
            book.Price = Price;
            book.Isbn = Isbn;
        }
    }
}
