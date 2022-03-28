using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.CORE.Abstract
{
    interface IBaseRepository<T> where T:class
    {
        bool Guncel(T entity);
        bool Sil(T entity);
        bool Ekle(T entity);
        T Bul(int Id);
        List<T> Liste();
        DbSet<T> Set();
        void Kaydet();
    }
}
