using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreExerciseProject.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public DateTime CreatedOn { get; set; }
        public string Narration { get; set; }

        public ICollection<LineItem> LineItems { get; set; }
    }
}
