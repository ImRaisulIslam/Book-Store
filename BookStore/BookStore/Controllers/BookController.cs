using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data);
        }
        public BookModel GetABook(int id)
        {
            return _bookRepository.GetBookById(id);
        }
        public List<BookModel> SearchBooks(string BookName , string AuthorName )
        {
            return _bookRepository.ScarchBook(BookName, AuthorName);
        }
    }
}