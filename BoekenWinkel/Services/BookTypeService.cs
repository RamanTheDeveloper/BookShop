using BoekenWinkel.Data;
using BoekenWinkel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoekenWinkel.Services
{
    public class BookTypeService
    {
        public int CreateBookType(BookType bookType)
        {
            using (var context = new ApplicationDbContext())
            {
                context.BookTypes.Add(bookType);
                context.SaveChanges();

                return bookType.Id;
            }
        }

        public BookType GetById(int bookTypeId)
        {
            using(var context = new ApplicationDbContext())
            {
                return context.BookTypes.Find(bookTypeId);
            }
        }
    }
}
