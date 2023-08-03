using Demo.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL.Abstract
{
    public interface IBookService
    {

        //Kendime not:Bu kısımda generic hale getir.
        void AddBook(Book book);

        void UpdateBook(Book book);

        List<Book> GetAllBooks();

        Book GetById(int id);

    }
}
