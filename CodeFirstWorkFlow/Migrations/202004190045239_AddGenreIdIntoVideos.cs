namespace CodeFirstWorkFlow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreIdIntoVideos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Videos", "GenreId");
            AddForeignKey("dbo.Videos","GenreId","dbo.Genres","Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "GenreId", "dbo.Genres");
            DropIndex("dbo.Videos", "GenreId");
            DropColumn("dbo.Videos", "GenreId");
        }
    }
}
