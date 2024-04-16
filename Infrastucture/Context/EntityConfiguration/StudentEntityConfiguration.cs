using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastucture.Context.EntityConfiguration
{
    public class StudentEntityConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasOne(x => x.User)
            .WithOne(x => x.Student).HasForeignKey<Student>(x => x.UserId);
            builder.HasMany(x => x.StudentCourses)
            .WithOne(x => x.Student);
            builder.HasMany(x => x.Results)
            .WithOne(x => x.Student);
        }

    }
}