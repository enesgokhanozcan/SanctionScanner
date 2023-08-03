using Demo.BL.Abstract;
using Demo.DA.Abstract;
using Demo.DA.Concrete.EntityFramework;
using Demo.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL.Concrete
{
    public class BookManager : IBookService
    {
        IBook _book;

        public BookManager(IBook book)
        {
            _book = book;
        }

        public void AddBook(Book book)
        {
            _book.Insert(book);
        }

        public List<Book> GetAllBooks()
        {
            return _book.GetAll();
        }

        public Book GetById(int id)
        {
            return _book.GetById(id);
        }

        public void UpdateBook(Book book)
        {
            _book.Update(book);
        }


    }
}
