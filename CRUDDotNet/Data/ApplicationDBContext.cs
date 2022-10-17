﻿namespace CRUDDotNet.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :
            base(options)
        {

        }

        public DbSet<Employee> Employee { get; set; }
    }
}
