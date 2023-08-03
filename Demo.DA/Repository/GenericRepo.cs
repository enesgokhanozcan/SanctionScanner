using Demo.DA.Abstract;
using Demo.DA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DA.Repository
{
    public class GenericRepo<T> : IGenericDA<T> where T : class
    {
        Context a = new Context();

        public List<T> GetAll()
        {
            return a.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return a.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
           a.Add(t);
           a.SaveChanges();
        }

        public void Update(T t)
        {
            a.Update(t);
            a.SaveChanges();
        }
    }
}
