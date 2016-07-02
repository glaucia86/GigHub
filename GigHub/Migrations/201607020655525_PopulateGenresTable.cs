namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, Name) VALUES(1, 'Jazz')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(2, 'Blues')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(3, 'Rock')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(4, 'Country')");
        }
        
        /* No método abaixo 'Down' tudo o que o método acima faz, ele fará o contrário! */
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id in(1,2,3,4)");
        }
    }
}
