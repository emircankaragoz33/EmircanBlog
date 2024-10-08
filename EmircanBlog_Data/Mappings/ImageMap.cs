﻿using EmircanBlog_Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmircanBlog_Data.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasMany(c => c.Articles).WithOne(c => c.Image).HasForeignKey(c => c.ImageId);
            builder.HasMany(c => c.Users).WithOne(c => c.Image).HasForeignKey(c => c.ImageId);

            builder.HasData(new Image
            {
                Id = Guid.Parse("F71F4B9A-AA60-461D-B398-DE31001BF214"),
                FileName = "images/testimage",
                FileType = "jpg",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });

     
        }
    }
}
