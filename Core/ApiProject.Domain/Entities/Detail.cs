﻿using ApiProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Domain.Entities
{
    public class Detail:EntitieBase
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


        public  string Title { get; set; }   
        public  string Description { get; set; } 
        public  int CategoryId { get; set; } 
        public Category Category { get; set; }
    }
}
