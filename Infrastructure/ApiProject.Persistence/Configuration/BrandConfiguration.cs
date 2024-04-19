using ApiProject.Domain.Entities;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Persistence.Configuration
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(256);

            Faker faker= new Faker("az");

            Brand faker1 = new()
            {
               Id=1,
                Name=faker.Commerce.Department() 
            };

            Brand faker2 = new()
            {
                Id =2,
                Name = faker.Commerce.Department()
            };
            Brand faker3 = new()
            {
                Id=3,
                Name = faker.Commerce.Department(),
                IsDeleted = true
            };

            builder.HasData(faker1,faker2,faker3);

        }
    }
}
