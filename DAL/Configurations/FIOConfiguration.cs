using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DAL.Configurations
{
    public class FIOConfiguration : IEntityTypeConfiguration<FIO>
    {

        public void Configure(EntityTypeBuilder<FIO> builder)
        {
            throw new NotImplementedException();
        }
    }
}
