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

        public ComputerSalonContext(DbContextOptions<ComputerSalonContext> options): base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SystemBlock>()
                .HasMany(systemBlock => systemBlock.SystemBlockComponents)
                .WithOne();

            modelBuilder.Entity<Value>()
                .HasOne(value => value.Attribute)
                .WithMany()
                .HasForeignKey(Value => Value.AttributeId);

            modelBuilder.Entity<SystemBlockComponent>()
                .HasOne(systemBlockComponent => systemBlockComponent.Component)
                .WithMany()
                .HasForeignKey(systemBlockComponent => systemBlockComponent.ComponentId);

            modelBuilder.Entity<Component>()
                .HasMany(component => component.Values)
                .WithOne();
        }
    }

}
