using MVC_Blog_Bountry_Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Blog_Bountry_Entity.Mapping
{
   public class CategoryMapping: EntityTypeConfiguration<Categorys>
    {
        public CategoryMapping()
        {
            ToTable("Categorys");
            HasKey(k => k.CateogryId);
            Property(k => k.CategoryName).HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
