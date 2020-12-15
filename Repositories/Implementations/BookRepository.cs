using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreExerciseProject.Data;
using AspNetCoreExerciseProject.Models;
using AspNetCoreExerciseProject.Repositories.Interfaces;

namespace AspNetCoreExerciseProject.Repositories.Implementations
{
    public class BookRepository: IBookRepository
    {
        private readonly BookStoreDbContext _context;

        public BookRepository(BookStoreDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Book>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Book> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Book> Save(Book entity)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Commit()
        {
            throw new NotImplementedException();
        }
    }
}
