using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entity.Concrete
{
    public class Book
    {
        public int Id { get; set; }

        public string BookName { get; set; }

        public string Author { get; set; }

        public string? BookImage { get; set; }

        public bool isRented { get; set; }

        public string? RentedName { get; set; }

        public DateTime? RentedDate { get; set; }

    }
}
