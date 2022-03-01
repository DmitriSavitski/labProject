using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DAL.Configurations
{
    public class DepartmentsConfiguration : IEntityTypeConfiguration<Departments>
    {

        public void Configure(EntityTypeBuilder<Departments> builder)
        {
            throw new NotImplementedException();
        }
    }
}
