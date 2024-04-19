using ApiProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Domain.Entities
{
    public class Brand:EntitieBase
    {
        public Brand()
        {
            
        }

        public Brand(string Name)
        {
            this.Name = Name;
        }
        public required string Name { get; set; }    

    }
}
