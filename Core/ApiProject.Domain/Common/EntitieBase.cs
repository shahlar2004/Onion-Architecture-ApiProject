using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Domain.Common
{
    public class EntitieBase:IEntitieBase
    {
        public int Id { get; set; } 
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public bool IsDeleted { get; set; } = false;

    }
}
