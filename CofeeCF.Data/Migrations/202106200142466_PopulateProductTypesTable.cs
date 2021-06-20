namespace CofeeCF.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateProductTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into ProductTypes Values ('Cakes')");
        }
        
        public override void Down()
        {
            Sql("Delete from ProductTypes Where Description='Cakes'");
        }
    }
}
