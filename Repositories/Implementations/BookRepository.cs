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
    public class BookRepository: IBookRepository
    {
        private readonly BookStoreDbContext _context;

        public BookRepository(BookStoreDbContext context)
        {
            _context = context;
        }
        public IQueryable<Book> GetAll()
        {
            return _context.Books;
        }

        public async Task<Book> Get(int id)
        {
            return await _context.Books
                .Include(b => b.ShoppingCartLines)
                .Include(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)
                .FirstOrDefaultAsync(i => i.Id == id);
        }

        public void Save(Book entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public async Task Add(Book entity)
        {
            await _context.AddAsync(entity);
        }

        public async Task<int> Commit()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
