using MVC_Blog_Bountry_Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Blog_Bountry_Entity.Mapping
{
    public class PostMapping: EntityTypeConfiguration<Posts>
    {
        public PostMapping()
        {
            ToTable("Posts");
            HasKey(k=>k.PostId);
            Property(k => k.PostTitle).HasColumnType("varchar").HasMaxLength(50);
            Property(k => k.PostText).HasColumnType("varchar").HasMaxLength(350);
            Property(k => k.ImageUrl).HasColumnType("varchar").HasMaxLength(350);
            Property(k => k.Date).HasColumnType("date");


            HasMany(u => u.Tags).WithMany(a => a.Posts).Map(m => {
                m.ToTable("Etiket_Post_Islem");
                m.MapLeftKey("EtiketId");
                m.MapRightKey("PostId");
            });

        }
    }
}
