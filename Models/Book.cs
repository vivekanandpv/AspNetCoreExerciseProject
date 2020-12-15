using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreExerciseProject.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Edition { get; set; }
        public string Category { get; set; }
        public int Pages { get; set; }
        public decimal Price { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
