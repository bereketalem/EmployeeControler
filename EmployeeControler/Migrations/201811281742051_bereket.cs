namespace EmployeeControler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bereket : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.NewTasks", "Worker_Id", "dbo.Workers");
            DropIndex("dbo.NewTasks", new[] { "Worker_Id" });
            AlterColumn("dbo.NewTasks", "TaskMame", c => c.String(nullable: false));
            AlterColumn("dbo.NewTasks", "Worker_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Workers", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.NewTasks", "Worker_Id");
            AddForeignKey("dbo.NewTasks", "Worker_Id", "dbo.Workers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NewTasks", "Worker_Id", "dbo.Workers");
            DropIndex("dbo.NewTasks", new[] { "Worker_Id" });
            AlterColumn("dbo.Workers", "Name", c => c.String());
            AlterColumn("dbo.NewTasks", "Worker_Id", c => c.Byte());
            AlterColumn("dbo.NewTasks", "TaskMame", c => c.String());
            CreateIndex("dbo.NewTasks", "Worker_Id");
            AddForeignKey("dbo.NewTasks", "Worker_Id", "dbo.Workers", "Id");
        }
    }
}
