namespace CodoPolygon.DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Chapters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArticleId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        SequenceNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articles", t => t.ArticleId, cascadeDelete: true)
                .Index(t => t.ArticleId);
            
            CreateTable(
                "dbo.ContentItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ChapterId = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false),
                        Content = c.String(nullable: false),
                        SequenceNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Chapters", t => t.ChapterId, cascadeDelete: true)
                .ForeignKey("dbo.ContentTypes", t => t.TypeId, cascadeDelete: true)
                .Index(t => t.ChapterId)
                .Index(t => t.TypeId);
            
            CreateTable(
                "dbo.ContentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 320),
                        Password = c.String(nullable: false, maxLength: 50),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.UsersArticles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ArticleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articles", t => t.ArticleId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ArticleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsersArticles", "UserId", "dbo.Users");
            DropForeignKey("dbo.UsersArticles", "ArticleId", "dbo.Articles");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.ContentItems", "TypeId", "dbo.ContentTypes");
            DropForeignKey("dbo.ContentItems", "ChapterId", "dbo.Chapters");
            DropForeignKey("dbo.Chapters", "ArticleId", "dbo.Articles");
            DropIndex("dbo.UsersArticles", new[] { "ArticleId" });
            DropIndex("dbo.UsersArticles", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.ContentItems", new[] { "TypeId" });
            DropIndex("dbo.ContentItems", new[] { "ChapterId" });
            DropIndex("dbo.Chapters", new[] { "ArticleId" });
            DropTable("dbo.UsersArticles");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
            DropTable("dbo.ContentTypes");
            DropTable("dbo.ContentItems");
            DropTable("dbo.Chapters");
            DropTable("dbo.Articles");
        }
    }
}
