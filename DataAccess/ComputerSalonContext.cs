using System;
using System.Data;
using System.Text;

using Data;

using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    class ComputerSalonContext: DbContext
    {
        public DbSet<Data.Type> Types
        { get; set; }

        public DbSet<SystemBlockHull> SystemBlockHulls
        { get; set; }

        public DbSet<SystemBlock> SystemBlocks
        { get; set; }

        public DbSet<SystemBlockComponent> SystemBlockComponents
        { get; set; }

        public DbSet<EnergyProducer> EnergyProducers
        { get; set; }

        public DbSet<EnergyComponent> EnergyComponents
        { get; set; }

        public DbSet<Component> Components
        { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SystemBlockComponent>()
                .HasOne<SystemBlock>()
                .WithMany(sb => sb.SystemBlockComponents)
                .HasForeignKey(c => c.SystemBlockId);

            modelBuilder.Entity<Component>()
                .HasOne(c => c.EnergyComponent)
                .WithOne()
                .HasForeignKey<EnergyComponent>(ec => ec.ComponentId);

            modelBuilder.Entity<Component>()
                .HasOne(c => c.EnergyProducer)
                .WithOne()
                .HasForeignKey<EnergyProducer>(ep => ep.ComponentId);

            modelBuilder.Entity<Component>()
                .HasOne(c => c.SystemBlockHull)
                .WithOne()
                .HasForeignKey<SystemBlockHull>(sbh => sbh.ComponentId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ComputerSalon;Username=postgres;Password=postgres");
        }
    }
}
