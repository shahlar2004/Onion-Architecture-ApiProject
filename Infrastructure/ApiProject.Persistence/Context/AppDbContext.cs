

using ApiProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Persistence.Context
{
    public class AppDbContext:DbContext
    {

        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }


        DbSet<Brand> brands { get; set; }   
        DbSet<Product> products { get; set; }
        DbSet<Detail> details { get; set; }
        DbSet<Category> categories { get; set; }
           
        DbSet<ProductCategory> productsCategory { get; set; }   


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

       
    }
}
