using RepositoryPatterninMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RepositoryPatterninMVC.Repository.Contract
{
    // Generic Repository
    public interface IGeneric<T> where T:class
    {
         List<T> GETALL();
         void Add(T Obj);
         T GetByID(int id);
         void Update(T Obj);
         void Delete(int id);
    }
}









