namespace CodeFirstWorkFlow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenrePopulation : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres (Id, Name) Values (1,'Comedy')");
            Sql("insert into Genres (Id, Name) Values (2,'Action')");
            Sql("insert into Genres (Id, Name) Values (3,'Horror')");
            Sql("insert into Genres (Id, Name) Values (4,'Thriller')");
            Sql("insert into Genres (Id, Name) Values (5,'Family')");
            Sql("insert into Genres (Id, Name) Values (6,'Romance')");
        }
        
        public override void Down()
        {
            Sql("delete from Genres");
        }
    }
}
