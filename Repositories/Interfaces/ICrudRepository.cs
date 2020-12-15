using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreExerciseProject.Repositories.Interfaces
{
    public interface ICrudRepository<T>
    {
        //  GetAll
        IQueryable<T> GetAll();
        //  GetById
        Task<T> Get(int id);
        //  Save
        void Save(T entity);
        //  Add
        Task Add(T entity);
        //  Commit
        Task<int> Commit();
    }
}
