namespace CodoPolygon.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ArticleUpdated_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "IsPublished", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Articles", "IsPublished");
        }
    }
}
