using BoekenWinkel.Data;
using BoekenWinkel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoekenWinkel.Services
{
    public class BookService
    {
        public int CreateBook(Book book)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Books.Add(book);
                context.SaveChanges();
            }

            return book.Id;
        }

        public Book GetById(int bookId)
        {
            using(var context = new ApplicationDbContext())
            {
                return context.Books.Find(bookId);
            }
        }

        public EditBook GetBookForEdit(int id)
        {
            using(var context = new ApplicationDbContext())
            {
                Book book = context.Books.Find(id);
                return new EditBook(book);
            }
        }

        public void UpdateBook(EditBook editBook)
        {
            using(var context = new ApplicationDbContext())
            {
                Book book = context.Books.Find(editBook.Id);
                editBook.Update(book);

                context.SaveChanges();
            }
        }
    }
}
