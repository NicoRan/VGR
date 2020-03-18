using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VGR.Models;

namespace VGR.Data.DataConfigurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder
                .HasKey(r => r.Id);

            //builder
            //    .HasMany(r => r.PowerUser.Reviews)
            //    .WithOne(u => u.)|

            builder
                .HasMany(r => r.Comments)
                .WithOne(c => c.Review);

            builder
                .Property(r => r.ReviewText)
                .IsRequired();

            builder
                .Property(r => r.GameName)
                .IsRequired();

            builder.Property(r => r.GamePublisher)
                .IsRequired();

            builder.Property(r => r.ReleaseYear)
                .IsRequired();

            builder.Property(r => r.VideoReview)
                .IsRequired();
        }
    }
}
