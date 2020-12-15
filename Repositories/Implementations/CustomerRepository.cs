using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreExerciseProject.Data;
using AspNetCoreExerciseProject.Models;
using AspNetCoreExerciseProject.Repositories.Interfaces;

namespace AspNetCoreExerciseProject.Repositories.Implementations
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly BookStoreDbContext _context;

        public CustomerRepository(BookStoreDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> Save(Customer entity)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Commit()
        {
            throw new NotImplementedException();
        }
    }
}
