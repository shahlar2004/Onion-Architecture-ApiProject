using ApiProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Domain.Entities
{
    public class Category:EntitieBase
    {

        public Category()
        {
            
        }


        public Category(int ParentId, string Name, int Priority)
        {
            this.ParentId = ParentId;
            this.Name = Name;
            this.Priority = Priority;
        }

        public int ParentId { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }


        public ICollection<Detail> Details { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }

   
}

    