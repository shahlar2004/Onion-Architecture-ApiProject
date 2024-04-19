using ApiProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Persistence.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new()
            {
                Id=1,
                Name="Elektrik",
                Priority=1,
                ParentId=0
            }; 
            
            Category category2 = new()
            {
                Id=2,
                Name="Moda",
                Priority=2,
                ParentId=0
            };  
            
            Category parent1 = new()
            {
                Id=3,
                Name="Bilgisayar",
                Priority=1,
                ParentId=1
            }; 
            
            Category parent2 = new()
            {
                Id=4,
                Name="Qadın",
                Priority=1,
                ParentId=2
            };


            builder.HasData(category1,category2,parent1,parent2);
        }
    }
}
