using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DAL.Configurations
{
    public class ProtocolConfigruration : IEntityTypeConfiguration<Protocol>
    {
        public void Configure(EntityTypeBuilder<Protocol> builder)
        {
            throw new NotImplementedException();
        }
    }
}
