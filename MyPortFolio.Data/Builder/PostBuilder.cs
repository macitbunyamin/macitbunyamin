﻿using MyPortFolio.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortFolio.Data.Builder
{
   public class PostBuilder
    {
        public PostBuilder(EntityTypeConfiguration<Post> entity) {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Title).IsRequired().HasMaxLength(100);
            entity.HasOptional(e => e.Category).WithMany(c => c.Posts).HasForeignKey(p => p.CategoryId);

        }
    }
}
