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
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Faker faker = new("az");

            Detail detail1 = new() 
            {
            Id=1,
            Title=faker.Lorem.Sentence(1),
            Description=faker.Lorem.Sentence(5),
            CategoryId=1
            
            }; 
            
            Detail detail2 = new() 
            {
            Id=2,
            Title=faker.Lorem.Sentence(1),
            Description=faker.Lorem.Sentence(5),
            CategoryId=3,
            IsDeleted=true
            };  
            
            Detail detail3 = new() 
            {
            Id=3,
            Title=faker.Lorem.Sentence(1),
            Description=faker.Lorem.Sentence(5),
            CategoryId=4
            };

            builder.HasData(detail1, detail2, detail3);

        }
    }
}
