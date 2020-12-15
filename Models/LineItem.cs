using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreExerciseProject.Models
{
    public class LineItem
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal LineAmount { get; set; }
    }
}
