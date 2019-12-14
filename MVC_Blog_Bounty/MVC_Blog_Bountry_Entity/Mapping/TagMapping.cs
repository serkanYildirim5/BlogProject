using MVC_Blog_Bountry_Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Blog_Bountry_Entity.Mapping
{
    public class TagMapping: EntityTypeConfiguration<Tags>
    {
        public TagMapping()
        {
            ToTable("Tags");
            HasKey(k => k.TagId);
            Property(k => k.TagName).HasColumnType("varchar").HasMaxLength(100);
        }
    }
}
