using Data;

using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class ComputerSalonContext : DbContext
    {
        public DbSet<Attribute> Attributes
        { get; set; }

        public DbSet<Data.Type> Types
        { get; set; }

        public DbSet<SystemBlock> SystemBlocks
        { get; set; }

        public DbSet<SystemBlockComponent> SystemBlockComponents
        { get; set; }

        public DbSet<Component> Components
        { get; set; }

        public DbSet<Value> Values
        { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SystemBlockComponent>()
                .HasOne<SystemBlock>()
                .WithMany(sb => sb.SystemBlockComponents)
                .HasForeignKey(c => c.SystemBlockId);

            modelBuilder.Entity<Value>()
                .HasOne(value => value.Attribute)
                .WithMany()
                .HasForeignKey(Value => Value.AttributeId);

            modelBuilder.Entity<Component>()
                .HasMany(component => component.Values)
                .WithOne();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ComputerSalonEAV;Username=postgres;Password=postgres");
        }
    }

}
