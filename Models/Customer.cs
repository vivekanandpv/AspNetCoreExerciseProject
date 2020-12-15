using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreExerciseProject.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }

        public ICollection<ShoppingCartLine> ShoppingCartLines { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
