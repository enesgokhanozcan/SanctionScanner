using Demo.DA.Abstract;
using Demo.DA.Repository;
using Demo.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DA.Concrete.EntityFramework
{
    public class EfBookRepo:GenericRepo<Book>,IBook
    {
    }
}
