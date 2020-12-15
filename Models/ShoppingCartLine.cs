using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreExerciseProject.Models
{
    public class ShoppingCartLine
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
        public bool IsInvoiced { get; set; }

        public DateTime AddedOn { get; set; }
        public DateTime? InvoicedOn { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
