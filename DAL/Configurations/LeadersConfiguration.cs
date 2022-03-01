using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DAL.Configurations
{
    public class LeadersConfiguration : IEntityTypeConfiguration<Leaders>
    {
        public void Configure(EntityTypeBuilder<Leaders> builder)
        {
            throw new NotImplementedException();
        }
    }
}
