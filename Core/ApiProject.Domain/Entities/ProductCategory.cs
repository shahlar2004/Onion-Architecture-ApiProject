using ApiProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Domain.Entities
{
    public class ProductCategory:IEntitieBase
    {
        public int ProductId { get; set; }  
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
