namespace EmployeeControler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createworkers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Workers (Id, Name) VALUES (1, 'Employee A')");
            Sql("INSERT INTO Workers (Id, Name) VALUES (2, 'Employee B')");
            Sql("INSERT INTO Workers (Id, Name) VALUES (3, 'Employee C')");
            Sql("INSERT INTO Workers (Id, Name) VALUES (4, 'Employee D')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Workers WHERE Id IN (1, 2, 3, 4)");
        }
    }
}
