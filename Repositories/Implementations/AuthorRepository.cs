using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreExerciseProject.Data;
using AspNetCoreExerciseProject.Models;
using AspNetCoreExerciseProject.Repositories.Interfaces;

namespace AspNetCoreExerciseProject.Repositories.Implementations
{
    public class AuthorRepository: IAuthorRepository
    {
        private readonly BookStoreDbContext _context;

        public AuthorRepository(BookStoreDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Author>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Author> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Author> Save(Author entity)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Commit()
        {
            throw new NotImplementedException();
        }
    }
}
