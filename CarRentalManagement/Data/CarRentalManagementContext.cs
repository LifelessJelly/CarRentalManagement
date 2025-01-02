using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Configurations.Entities;

namespace CarRentalManagement.Data
{
    public class CarRentalManagementContext : DbContext
    {
        public CarRentalManagementContext (DbContextOptions<CarRentalManagementContext> options)
            : base(options)
        {
        }

        public DbSet<Components.Domain.Make> Make { get; set; } = default!;
        public DbSet<Components.Domain.Model> Model { get; set; } = default!;
        public DbSet<Components.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<Components.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<Components.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<Components.Domain.Booking> Booking { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ColourSeed());
            modelBuilder.ApplyConfiguration(new MakeSeed());
            modelBuilder.ApplyConfiguration(new ModelSeed());
        }
    }
}
