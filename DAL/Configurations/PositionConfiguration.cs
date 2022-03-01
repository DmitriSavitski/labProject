using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DAL.Configurations
{
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {

        public void Configure(EntityTypeBuilder<Position> builder)
        {
            throw new NotImplementedException();
        }
    }
}
