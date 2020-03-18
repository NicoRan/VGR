using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VGR.Models;

namespace VGR.Data.DataConfigurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder
                .HasKey(c => c.Id);

            builder
                .HasOne(c => c.Review)
                .WithMany(r => r.Comments);

            builder
                .Property(c => c.CommentText)
                .IsRequired();

            builder
                .Property(c => c.EmailAddress)
                .IsRequired();

            builder
                .Property(c => c.UserName)
                .IsRequired();



        }
    }
}
