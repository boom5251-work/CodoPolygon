namespace CodoPolygon.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TypesUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContentTypes", "UniqueCode", c => c.Int(nullable: false));
            AddColumn("dbo.Roles", "UniqueCode", c => c.Int(nullable: false));
            CreateIndex("dbo.ContentTypes", "UniqueCode", unique: true);
            CreateIndex("dbo.Roles", "UniqueCode", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Roles", new[] { "UniqueCode" });
            DropIndex("dbo.ContentTypes", new[] { "UniqueCode" });
            DropColumn("dbo.Roles", "UniqueCode");
            DropColumn("dbo.ContentTypes", "UniqueCode");
        }
    }
}
