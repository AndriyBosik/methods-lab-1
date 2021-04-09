using System;
using System.Collections.Generic;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ComputerSalon;Username=postgres;Password=postgres");
        }
    }
}
