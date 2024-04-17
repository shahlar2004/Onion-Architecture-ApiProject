using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Domain.Entities
{
    public class Detail
    {

        public Detail()
        {
            
        }

        public Detail(string Title, string Description, int CategoryId)
        {
            this.Title = Title;
            this.Description = Description;
            this.CategoryId = CategoryId;
        }


        public required string Title { get; set; }   
        public required string Description { get; set; } 
        public required int CategoryId { get; set; } 
        public Category Category { get; set; }
    }
}
