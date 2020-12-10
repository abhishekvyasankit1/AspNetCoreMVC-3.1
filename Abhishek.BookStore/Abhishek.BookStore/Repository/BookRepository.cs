using Abhishek.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abhishek.BookStore.Repository
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
        public List<BookModel> SearchBook(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title="MVC", Author = "Abhishek"},
                new BookModel(){Id=2, Title="Dot Net Core", Author = "Abhishek"},
                new BookModel(){Id=3, Title="C#", Author = "Ankit"},
                new BookModel(){Id=4, Title="Php", Author = "Rudrakshi"},
                new BookModel(){Id=5, Title="Java", Author = "Akshu"},
            };
        }
    }
}
