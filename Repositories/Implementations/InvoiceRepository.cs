using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreExerciseProject.Data;
using AspNetCoreExerciseProject.Models;
using AspNetCoreExerciseProject.Repositories.Interfaces;

namespace AspNetCoreExerciseProject.Repositories.Implementations
{
    public class InvoiceRepository: IInvoiceRepository
    {
        private readonly BookStoreDbContext _context;

        public InvoiceRepository(BookStoreDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Invoice>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Invoice> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Invoice> Save(Invoice entity)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Commit()
        {
            throw new NotImplementedException();
        }
    }
}
