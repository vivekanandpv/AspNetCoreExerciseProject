using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreExerciseProject.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreExerciseProject.Data
{
    public class BookStoreDbContext: DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> dbConfiguration) : base(dbConfiguration)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<ShoppingCartLine> ShoppingCartLines { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        
        //  relations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            //  BookAuthor
            modelBuilder.Entity<BookAuthor>()
                .HasOne(ba => ba.Author)
                .WithMany(a => a.BookAuthors)
                .HasForeignKey(ba => ba.AuthorId);

            modelBuilder.Entity<BookAuthor>()
                .HasOne(ba => ba.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(ba => ba.BookId);

            modelBuilder.Entity<BookAuthor>()
                .HasKey(ba => new
                {
                    ba.AuthorId, ba.BookId
                });

            //  LineItem
            modelBuilder.Entity<LineItem>()
                .HasOne(li => li.Book)
                .WithMany(b => b.LineItems)
                .HasForeignKey(li => li.BookId);

            modelBuilder.Entity<LineItem>()
                .HasOne(li => li.Invoice)
                .WithMany(i => i.LineItems)
                .HasForeignKey(li => li.InvoiceId);

            modelBuilder.Entity<LineItem>()
                .HasKey(li => li.Id);


            //  ShoppingCartLine
            modelBuilder.Entity<ShoppingCartLine>()
                .HasOne(scl => scl.Customer)
                .WithMany(c => c.ShoppingCartLines)
                .HasForeignKey(scl => scl.CustomerId);

            modelBuilder.Entity<ShoppingCartLine>()
                .HasOne(scl => scl.Book)
                .WithMany(b => b.ShoppingCartLines)
                .HasForeignKey(scl => scl.BookId);

            modelBuilder.Entity<ShoppingCartLine>()
                .HasKey(scl => scl.Id);


            //  Invoice-Customer
            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.Customer)
                .WithMany(c => c.Invoices)
                .HasForeignKey(i => i.CustomerId);
        }
    }
}
