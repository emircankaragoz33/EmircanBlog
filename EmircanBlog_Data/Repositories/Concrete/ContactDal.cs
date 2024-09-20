﻿using EmircanBlog_Data.Context;
using EmircanBlog_Data.Repositories.Abstract;
using EmircanBlog_Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmircanBlog_Data.Repositories.Concrete
{
    public class ContactDal : GenericRepository<Contact>, IContactDal
    {
        public ContactDal(EmircanContext emircanContext) : base(emircanContext)
        {
        }
    }
}
