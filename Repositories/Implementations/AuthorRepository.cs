using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreExerciseProject.Data;
using AspNetCoreExerciseProject.Models;
using AspNetCoreExerciseProject.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreExerciseProject.Repositories.Implementations
{
    public class AuthorRepository: IAuthorRepository
    {
        private readonly BookStoreDbContext _context;

        public AuthorRepository(BookStoreDbContext context)
        {
            _context = context;
        }
        public IQueryable<Author> GetAll()
        {
            return _context.Authors;
        }

        public async Task<Author> Get(int id)
        {
            return await _context.Authors
                .Include(a => a.BookAuthors)
                .ThenInclude(ba => ba.Author)
                .FirstOrDefaultAsync(i => i.Id == id);
        }

        public void Save(Author entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public async Task Add(Author entity)
        {
            await _context.AddAsync(entity);
        }

        public async Task<int> Commit()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
