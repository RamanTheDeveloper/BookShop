using BoekenWinkel.Models;
using BoekenWinkel.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoekenWinkel.Controllers
{
    public class BookTypeController : Controller
    {
        private readonly BookTypeService _service = new BookTypeService();

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BookType bookType)
        {
            if (ModelState.IsValid)
            {
                //booktype bewaren in db
                int id = _service.CreateBookType(bookType);

                return RedirectToAction(nameof(Details), new { id = id });
            }

            return View(bookType);
        }

        public IActionResult Details(int id)
        {
            BookType bookType = _service.GetById(id);

            return View(bookType);
        }
    }
}
