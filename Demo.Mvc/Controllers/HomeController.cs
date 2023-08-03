using Demo.BL.Concrete;
using Demo.DA.Concrete.EntityFramework;
using Demo.Entity.Concrete;
using Demo.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace Demo.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        BookManager bookManager = new BookManager(new EfBookRepo());

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            var books = bookManager.GetAllBooks().OrderBy(q=>q.BookName).ToList();
            return View(books);
        }

        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(Book book, IFormFile BookImage)
        {

            if (BookImage != null && BookImage.Length > 0)
            {
                var imagePath = Path.Combine("wwwroot\\Assets\\", BookImage.FileName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    BookImage.CopyTo(stream);
                }

                book.BookImage = "Assets/" + BookImage.FileName;
            }
            else
            {
                book.BookImage = "";
            }

            book.isRented = false;
            bookManager.AddBook(book);

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult UpdateUser(int id,string name,DateTime dateTime) 
        {   
            var bookDetail= bookManager.GetById(id);

            bookDetail.isRented = true;
            bookDetail.RentedName = name;
            bookDetail.RentedDate= dateTime;
            bookManager.UpdateBook(bookDetail);

            return new JsonResult("Ödünç alma işlemi başarıyla gerçekleştirilmiştir.");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}