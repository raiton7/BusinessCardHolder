namespace BusinessCardHolder.DataBase
{
    using global::BusinessCardHolder.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BusinessCardHolderContext : DbContext
    {
        public BusinessCardHolderContext()
            : base("name=BusinessCardHolderContext")
        {
        }
        public DbSet<EmployeeModel> Employees { get; set; }
        public DbSet<CompanyModel> Companies { get; set; }
    }
}