using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        public DbSet<DiaryEntry> DiaryEntries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry { DairyId = 1, Title = "Felipe en la pizzeria", Description="Felipe comio pizza", CreatedAt = DateTime.Now },
                new DiaryEntry { DairyId = 2, Title = "Felipe en la heladeria", Description="Felipe comio helado", CreatedAt = DateTime.Now }
                );
        }
    }
}
