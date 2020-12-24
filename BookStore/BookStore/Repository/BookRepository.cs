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
        public List<BookModel> ScarchBook(string BooksName, string AuthorsName)
        {
            return DataSource().Where(x => x.Title.Contains(BooksName) || x.Author.Contains(AuthorsName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){ Id=1,Title="MVC",Author="Raisul",Descrption="This is Description 1" },
                new BookModel(){ Id=2,Title="C#",Author="Rashed" ,Descrption="This is Description 2" },

                new BookModel(){ Id=3,Title="PHP",Author="Rasel",Descrption="This is Description 3"  },



            };
        }
    }
}
