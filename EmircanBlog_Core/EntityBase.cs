﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmircanBlog_Core
{
    public abstract class EntityBase : IEntityBase
    {
        protected EntityBase()
        {

        }

        public virtual Guid Id { get; set; } = Guid.NewGuid();
        public virtual string? CreatedBy { get; set; }
        public virtual string? ModifiedBy { get; set; }
        public virtual string? DeletedBy { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual bool IsDeleted { get; set; }
    }
}
