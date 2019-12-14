using MVC_Blog_Bountry_Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Blog_Bountry_Entity.Mapping
{
    public class UserMapping: EntityTypeConfiguration<Users>
    {
        public UserMapping()
        {
            ToTable("Users");
            HasKey(k => k.UserId);
            Property(k => k.Email).HasColumnType("varchar").HasMaxLength(250);
            Property(k => k.UserName).HasColumnType("varchar").HasMaxLength(150);
            Property(k => k.Password).HasColumnType("varchar").HasMaxLength(250);
        }
    }
}
