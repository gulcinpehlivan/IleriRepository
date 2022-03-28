using IleriRepository.CORE.Abstract;
using IleriRepository.Models.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IleriRepository.CORE.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        PersonelContext db = new PersonelContext();
        public T Bul(int Id)
        {
            return Set().Find(Id);
        }

        public bool Ekle(T entity)
        {
            try
            {
                db.Entry(entity).State = EntityState.Added;
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool Guncel(T entity)
        {
            try
            {
                db.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void Kaydet()
        {
            db.SaveChanges();
        }

        public List<T> Liste()
        {
           return Set().ToList();
        }

        public DbSet<T> Set()
        {
            return db.Set<T>();
        }

        public bool Sil(T entity)
        {
            try
            {
                db.Entry(entity).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}