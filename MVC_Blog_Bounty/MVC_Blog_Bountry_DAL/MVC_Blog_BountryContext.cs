using MVC_Blog_Bountry_Entity.Mapping;
using MVC_Blog_Bountry_Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Blog_Bountry_DAL
{
    public class MVC_Blog_BountryContext : DbContext
    {
        public MVC_Blog_BountryContext():base(ConnectionStringContainer.ConnectionString)
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Categorys> Categorys { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new CommentMapping());
            modelBuilder.Configurations.Add(new PostMapping());
            modelBuilder.Configurations.Add(new TagMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            base.OnModelCreating(modelBuilder);
        }

    }
}
