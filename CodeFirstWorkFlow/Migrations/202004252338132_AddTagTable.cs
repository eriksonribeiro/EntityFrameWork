namespace CodeFirstWorkFlow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTagTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VideosTags",
                c => new
                    {
                        VideoId = c.Int(nullable: false),
                        TagId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.VideoId, t.TagId })
                .ForeignKey("dbo.Videos", t => t.VideoId, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagId, cascadeDelete: true)
                .Index(t => t.VideoId)
                .Index(t => t.TagId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VideosTags", "TagId", "dbo.Tags");
            DropForeignKey("dbo.VideosTags", "VideoId", "dbo.Videos");
            DropIndex("dbo.VideosTags", new[] { "TagId" });
            DropIndex("dbo.VideosTags", new[] { "VideoId" });
            DropTable("dbo.VideosTags");
            DropTable("dbo.Tags");
        }
    }
}
