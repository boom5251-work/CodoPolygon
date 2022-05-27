namespace CodoPolygon.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ArticleUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "LatShortName", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Articles", "LatShortName", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Articles", new[] { "LatShortName" });
            DropColumn("dbo.Articles", "LatShortName");
        }
    }
}
