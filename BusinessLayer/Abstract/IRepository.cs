using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRepository<T> where T:class, new()
    {
        List<T> List();
        void Insert(T p); //T entity ve bir parametreye göre işlem yapacak
        void Delete(T p);
        void Update(T p);
        T GetById(int id);
    }
}
