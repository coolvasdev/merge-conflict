using Microsoft.EntityFrameworkCore;
using UserSearchApp.Models;

namespace UserSearchApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed sample data
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    PhoneNumber = "555-1234",
                    Address = "123 Main St, Springfield, IL 62701"
                },
                new User
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    PhoneNumber = "555-5678",
                    Address = "456 Oak Ave, Chicago, IL 60601"
                },
                new User
                {
                    Id = 3,
                    FirstName = "Robert",
                    LastName = "Johnson",
                    PhoneNumber = "555-9012",
                    Address = "789 Pine Rd, Naperville, IL 60540"
                },
                new User
                {
                    Id = 4,
                    FirstName = "Emily",
                    LastName = "Davis",
                    PhoneNumber = "555-3456",
                    Address = "321 Elm St, Aurora, IL 60505"
                },
                new User
                {
                    Id = 5,
                    FirstName = "Michael",
                    LastName = "Brown",
                    PhoneNumber = "555-7890",
                    Address = "654 Maple Dr, Peoria, IL 61602"
                }
            );
        }
    }
}
