using Microsoft.EntityFrameworkCore;
using TyperProject.Auth;
using TyperProject.Records;
using TyperProject.Words;

namespace TyperProject
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Word> Words { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Word>().HasData(
                new Word { Id = 1, WordString = "time" },
                new Word { Id = 2, WordString = "year" },
                new Word { Id = 3, WordString = "people" },
                new Word { Id = 4, WordString = "way" },
                new Word { Id = 5, WordString = "day" },
                new Word { Id = 6, WordString = "man" },
                new Word { Id = 7, WordString = "thing" },
                new Word { Id = 8, WordString = "woman" },
                new Word { Id = 9, WordString = "life" },
                new Word { Id = 10, WordString = "child" },
                new Word { Id = 11, WordString = "world" },
                new Word { Id = 12, WordString = "school" },
                new Word { Id = 13, WordString = "state" },
                new Word { Id = 14, WordString = "family" },
                new Word { Id = 15, WordString = "student" },
                new Word { Id = 16, WordString = "group" },
                new Word { Id = 17, WordString = "country" },
                new Word { Id = 18, WordString = "problem" },
                new Word { Id = 19, WordString = "hand" },
                new Word { Id = 20, WordString = "part" },
                new Word { Id = 21, WordString = "place" },
                new Word { Id = 22, WordString = "case" },
                new Word { Id = 23, WordString = "week" },
                new Word { Id = 24, WordString = "company" },
                new Word { Id = 25, WordString = "system" },
                new Word { Id = 26, WordString = "program" },
                new Word { Id = 27, WordString = "question" },
                new Word { Id = 28, WordString = "work" },
                new Word { Id = 29, WordString = "government" },
                new Word { Id = 30, WordString = "number" }
            );
        }
    }
}
