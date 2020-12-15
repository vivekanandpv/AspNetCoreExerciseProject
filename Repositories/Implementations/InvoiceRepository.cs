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
    public class InvoiceRepository: IInvoiceRepository
    {
        private readonly BookStoreDbContext _context;

        public InvoiceRepository(BookStoreDbContext context)
        {
            _context = context;
        }
        public IQueryable<Invoice> GetAll()
        {
            return _context.Invoices;
        }

        public async Task<Invoice> Get(int id)
        {
            return await _context.Invoices
                .Include(i => i.LineItems)
                .ThenInclude(li => li.Book)
                .FirstOrDefaultAsync(i => i.Id == id);
        }

        public void Save(Invoice entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public async Task Add(Invoice entity)
        {
            await _context.AddAsync(entity);
        }

        public async Task<int> Commit()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
