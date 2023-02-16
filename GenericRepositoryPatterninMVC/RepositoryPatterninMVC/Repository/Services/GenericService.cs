using RepositoryPatterninMVC.Models;
using RepositoryPatterninMVC.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RepositoryPatterninMVC.Repository.Services
{
    public class GenericService<T> : IGeneric<T> where T : class
    {
        private GenericDbContext _context = null;
        private DbSet<T> table = null;
        public GenericService()
        {
            _context = new GenericDbContext();
            table = _context.Set<T>();
        }

        public List<T> GETALL()
        {
            return table.ToList();
        }

        public T GetByID(int id)
        {
            return table.Find(id);
        }
        public void Add(T Obj)
        {
            table.Add(Obj);
            _context.SaveChanges();
        }
        public void Update(T Obj)
        {
            table.Attach(Obj);
            _context.Entry(Obj).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
         T exist=table.Find(id);
         table.Remove(exist);
         _context.SaveChanges();
        }
    }
}