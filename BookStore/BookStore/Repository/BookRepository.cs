using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {

        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> ScarchBook(string BookName, string AutherName)
        {
            return DataSource().Where(x => x.Title.Contains(BookName) && x.Author.Contains(AutherName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){ Id=1,Title="MVC",Author="Raisul" },
                new BookModel(){ Id=2,Title="MVC",Author="Pollob" },

                new BookModel(){ Id=3,Title="MVC",Author="Rasel" },



            };
        }
    }
}
