using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreExerciseProject.Repositories.Interfaces
{
    public interface ICrudRepository<T>
    {
        //  GetAll
        Task<IEnumerable<T>> GetAll();
        //  GetById
        Task<T> Get(int id);
        //  Save
        Task<T> Save(T entity);
        //  Commit
        Task<int> Commit();
    }
}
