namespace CodeFirstWorkFlow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterVideoTable : DbMigration
    {
        public override void Up()
        {
            //Sql("ALTER TABLE dbo.Videos DROP CONSTRAINT DF__Videos__GenreId__5AEE82B9");
            DropForeignKey("dbo.Videos", "GenreId", "dbo.Genres");
            DropIndex("dbo.Videos", "IX_GenreId");
            AlterColumn("dbo.Videos", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Videos", "GenreId");
            AddForeignKey("dbo.Videos", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "GenreId", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "GenreId" });
            AlterColumn("dbo.Videos", "Name", c => c.String());
            CreateIndex("dbo.Videos", "GenreId");
            AddForeignKey("dbo.Videos", "GenreId", "dbo.Genres", "Id");

        }
    }
}
