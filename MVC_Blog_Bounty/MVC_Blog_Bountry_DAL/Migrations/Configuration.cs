namespace MVC_Blog_Bountry_DAL.Migrations
{
    using MVC_Blog_Bountry_Entity.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_Blog_Bountry_DAL.MVC_Blog_BountryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVC_Blog_Bountry_DAL.MVC_Blog_BountryContext context)
        {

            //List<Tags> etiketler = new List<Tags>() {
            //    new Tags(){TagName="Css"},
            //    new Tags(){TagName="Html"},
            //    new Tags(){TagName="Framework"},
            //    new Tags(){TagName="MVC"}
            //};
            //context.Tags.AddRange(etiketler);
            //context.SaveChanges();

            //List<Users> kullanıcılar = new List<Users>()
            //{
            //    new Users(){Email="serkan@gmail.com",UserName="Serkan",Password="1234"},
            //    new Users(){Email="admin@gmail.com",UserName="Admin",Password="1234"},
            //};
            //context.Users.AddRange(kullanıcılar);
            //context.SaveChanges();

            //List<Categorys> kategoriler = new List<Categorys>()
            //{
            //    new Categorys(){CategoryName="Yazılım"},
            //    new Categorys(){CategoryName="Spor"},
            //    new Categorys(){CategoryName="Doğa"}
            //};
            //context.Categorys.AddRange(kategoriler);
            //context.SaveChanges();

            //List<Posts> makaleler = new List<Posts>() {
            //    new Posts(){PostTitle="Gelisiyoruz",
            //        PostText ="Yazılım dünyası gün geçtikçe gelisiyoruz..",
            //        PostActive =true,
            //        Date =DateTime.Now,
            //        CategoryId =2,
            //        ImageUrl ="Assets/img/i1.jpg",
            //        Tags =new List<Tags>
            //            { new Tags{TagName= "Css"} }
            //    },
            //    new Posts(){PostTitle="Gelisiyoruz",
            //        PostText ="Yazılım dünyası gün geçtikçe gelisiyoruz..",
            //        PostActive =true,
            //        Date =DateTime.Now,
            //        CategoryId =2,
            //        ImageUrl ="Assets/img/i1.jpg",
            //        Tags =new List<Tags>
            //            { new Tags{TagName= "Css"} }
            //    },
            //    new Posts(){PostTitle="Gelisiyoruz",
            //        PostText ="Yazılım dünyası gün geçtikçe gelisiyoruz..",
            //        PostActive =true,
            //        Date =DateTime.Now,
            //        CategoryId =2,
            //        ImageUrl ="Assets/img/i1.jpg",
            //        Tags =new List<Tags>
            //            { new Tags{TagName= "Framework"} }
            //    },new Posts(){PostTitle="Gelisiyoruz",
            //        PostText ="Yazılım dünyası gün geçtikçe gelisiyoruz..",
            //        PostActive =true,
            //        Date =DateTime.Now,
            //        CategoryId =2,
            //        ImageUrl ="Assets/img/i1.jpg",
            //        Tags =new List<Tags>
            //            { new Tags{TagName= "Html"} }
            //    }
            //};
            //context.Posts.AddRange(makaleler);
            //context.SaveChanges();

            List<Comments> yorumlar = new List<Comments>()
            {
                new Comments(){FullName="Serkan Yıldırım",Email="serkan@gmail.com",Subject="Faydalı",Comment="Cok faydalı oldu.",PostId=4},
                new Comments(){FullName="Mert Ömgen",Email="mert@gmail.com",Subject="Faydalı",Comment="Cok faydalı oldu.",PostId=5},new Comments(){FullName="Serkan Yıldırım",Email="serkan@gmail.com",Subject="Faydalı",Comment="Cok faydalı oldu.",PostId=5},
                new Comments(){FullName="Mert Ömgen",Email="mert@gmail.com",Subject="Faydalı",Comment="Cok faydalı oldu.",PostId=6}
            };
            context.Comments.AddRange(yorumlar);
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
