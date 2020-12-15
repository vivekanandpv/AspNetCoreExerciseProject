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
    public class CustomerRepository: ICustomerRepository
    {
        private readonly BookStoreDbContext _context;

        public CustomerRepository(BookStoreDbContext context)
        {
            _context = context;
        }
        public IQueryable<Customer> GetAll()
        {
            return _context.Customers;
        }

        public async Task<Customer> Get(int id)
        {
            return await _context.Customers
                .Include(c => c.Invoices)
                .Include(c => c.ShoppingCartLines)
                .FirstOrDefaultAsync(i => i.Id == id);
        }

        public void Save(Customer entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public async Task Add(Customer entity)
        {
            await _context.AddAsync(entity);
        }

        public async Task<int> Commit()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
