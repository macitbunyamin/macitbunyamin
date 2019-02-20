using MyPortFolio.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortFolio.Data.Builder
{
    public class CategoryBuilder
    {

        public CategoryBuilder(EntityTypeConfiguration<Category> entity) {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).HasMaxLength(100);

        }
    }
}
