namespace BusinessCardHolder.DataBase
{
    using System;
    using System.Data.Entity;
    using BusinessCardHolder.Models;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BusinessCardHolderContext : DbContext
    {
        public BusinessCardHolderContext()
            : base("name=BusinessCardHolderContext")
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);
        }
    }
}
