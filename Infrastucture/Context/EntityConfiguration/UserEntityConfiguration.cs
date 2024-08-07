using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastucture.Context.EntityConfiguration
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.CreatedOn).HasColumnType("datetime(0)");
            builder.Property(x => x.ModifiedOn).HasColumnType("datetime(0)");
            builder.Property(x => x.Password).IsRequired().HasColumnType("varchar(50)");
            builder.Property(x => x.Username).IsRequired().HasColumnType("varchar(50)");
            builder.Property(x => x.ModifiedBy).IsRequired().HasColumnType("varchar(50)");
            builder.Property(x => x.CreatedBy).IsRequired().HasColumnType("varchar(50)");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Username).IsRequired(true);
        }

    }
}