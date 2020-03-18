using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VGR.Models;

namespace VGR.Data.DataConfigurations
{
    public class PowerUserConfiguration : IEntityTypeConfiguration<PowerUser>
    {
        public void Configure(EntityTypeBuilder<PowerUser> builder)
        {
            builder
                .HasKey(u => u.Id);

            //builder
            //    .HasMany(u => u.Reviews)
            //    .WithOne(r => r.PowerUser);
        }
    }
}
