using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DAL.Configurations
{
    public class NationalityConfiguration : IEntityTypeConfiguration<Nationality>
    {

        public void Configure(EntityTypeBuilder<Nationality> builder)
        {
            throw new NotImplementedException();
        }
    }
}
