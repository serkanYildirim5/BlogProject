using MVC_Blog_Bountry_Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Blog_Bountry_Entity.Mapping
{
    public class CommentMapping: EntityTypeConfiguration<Comments>
    {
        public CommentMapping()
        {
            ToTable("Comments");
            HasKey(k => k.CommentId);
            Property(k => k.Subject).HasColumnType("varchar").HasMaxLength(50);
            Property(k => k.Comment).HasColumnType("varchar").HasMaxLength(350);
            Property(k => k.Email).HasColumnType("varchar").HasMaxLength(250);
            Property(k => k.FullName).HasColumnType("varchar").HasMaxLength(150);

            
        }
    }
}
