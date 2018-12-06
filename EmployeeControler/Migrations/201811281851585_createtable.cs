namespace EmployeeControler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewTasks", "TaskName", c => c.String(nullable: false));
            DropColumn("dbo.NewTasks", "TaskMame");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NewTasks", "TaskMame", c => c.String(nullable: false));
            DropColumn("dbo.NewTasks", "TaskName");
        }
    }
}
