using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DAL.Configurations
{
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {

        public void Configure(EntityTypeBuilder<Status> builder)
        {
            throw new NotImplementedException();
        }
    }
}
