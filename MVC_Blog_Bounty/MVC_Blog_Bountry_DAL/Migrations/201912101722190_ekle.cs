namespace MVC_Blog_Bountry_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorys",
                c => new
                    {
                        CateogryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.CateogryId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        PostTitle = c.String(maxLength: 50, unicode: false),
                        PostText = c.String(maxLength: 350, unicode: false),
                        PostActive = c.Boolean(nullable: false),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                        ImageUrl = c.String(maxLength: 350, unicode: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PostId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 150, unicode: false),
                        Email = c.String(maxLength: 250, unicode: false),
                        Subject = c.String(maxLength: 50, unicode: false),
                        Comment = c.String(maxLength: 350, unicode: false),
                        PostId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .Index(t => t.PostId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TagId = c.Int(nullable: false, identity: true),
                        TagName = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.TagId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 250, unicode: false),
                        UserName = c.String(maxLength: 150, unicode: false),
                        Password = c.String(maxLength: 250, unicode: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.PostsCategorys",
                c => new
                    {
                        Posts_PostId = c.Int(nullable: false),
                        Categorys_CateogryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Posts_PostId, t.Categorys_CateogryId })
                .ForeignKey("dbo.Posts", t => t.Posts_PostId, cascadeDelete: true)
                .ForeignKey("dbo.Categorys", t => t.Categorys_CateogryId, cascadeDelete: true)
                .Index(t => t.Posts_PostId)
                .Index(t => t.Categorys_CateogryId);
            
            CreateTable(
                "dbo.Etiket_Post_Islem",
                c => new
                    {
                        EtiketId = c.Int(nullable: false),
                        PostId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EtiketId, t.PostId })
                .ForeignKey("dbo.Posts", t => t.EtiketId, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.PostId, cascadeDelete: true)
                .Index(t => t.EtiketId)
                .Index(t => t.PostId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Etiket_Post_Islem", "PostId", "dbo.Tags");
            DropForeignKey("dbo.Etiket_Post_Islem", "EtiketId", "dbo.Posts");
            DropForeignKey("dbo.Comments", "PostId", "dbo.Posts");
            DropForeignKey("dbo.PostsCategorys", "Categorys_CateogryId", "dbo.Categorys");
            DropForeignKey("dbo.PostsCategorys", "Posts_PostId", "dbo.Posts");
            DropIndex("dbo.Etiket_Post_Islem", new[] { "PostId" });
            DropIndex("dbo.Etiket_Post_Islem", new[] { "EtiketId" });
            DropIndex("dbo.PostsCategorys", new[] { "Categorys_CateogryId" });
            DropIndex("dbo.PostsCategorys", new[] { "Posts_PostId" });
            DropIndex("dbo.Comments", new[] { "PostId" });
            DropTable("dbo.Etiket_Post_Islem");
            DropTable("dbo.PostsCategorys");
            DropTable("dbo.Users");
            DropTable("dbo.Tags");
            DropTable("dbo.Comments");
            DropTable("dbo.Posts");
            DropTable("dbo.Categorys");
        }
    }
}
