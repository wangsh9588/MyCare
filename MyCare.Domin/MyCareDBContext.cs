using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyCare.Domin.Entities;

namespace MyCare.Domin
{
    public class MyCareDBContext : DbContext
    {
        public MyCareDBContext()
        {

        }
        public MyCareDBContext(DbContextOptions<MyCareDBContext> options) : base(options)
        {

        }
        public DbSet<People> People { get; set; }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<Timesheet> Timesheets { get; set; }

        public DbSet<Venue> Venues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("MyCare");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyCare;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
