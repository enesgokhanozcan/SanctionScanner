using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DA.Abstract
{
    public interface IGenericDA<T> where T : class
    {
        void Insert(T t);

        void Update(T t);

        List<T> GetAll();

        T GetById(int id);

    }
}
