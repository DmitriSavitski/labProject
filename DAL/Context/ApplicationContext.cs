using DAL.Configurations;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Protocol> Protocol { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<FIO> FIO { get; set; }
        public DbSet<Nationality> Nationality { get; set; }
        public DbSet<Leaders> Leaders { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder = builder ?? throw new ArgumentNullException(nameof(builder));

        //    builder.ApplyConfiguration(new UsersConfiguration());
        //    builder.ApplyConfiguration(new RoleConfiguration());
        //    builder.ApplyConfiguration(new PositionConfiguration());
        //    builder.ApplyConfiguration(new StatusConfiguration());
        //    builder.ApplyConfiguration(new ProtocolConfigruration());
        //    builder.ApplyConfiguration(new EmployeesConfiguration());
        //    builder.ApplyConfiguration(new DepartmentsConfiguration());
        //    builder.ApplyConfiguration(new FIOConfiguration());
        //    builder.ApplyConfiguration(new NationalityConfiguration());
        //    builder.ApplyConfiguration(new LeadersConfiguration());

        //    base.OnModelCreating(builder);
        //}
    }
}
