﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmircanBlog_Entity.Entities
{
    public class BlogUser : IdentityUser<Guid>
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }

        public Guid ImageId { get; set; }
        public Image Image { get; set; }

        public ICollection<Article> Articles { get; set; }  
        public ICollection<Category> Categories { get; set; }  
   
    }
}
