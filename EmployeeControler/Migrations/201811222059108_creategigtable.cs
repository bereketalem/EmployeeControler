namespace EmployeeControler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creategigtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TaskMame = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        Worker_Id = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Workers", t => t.Worker_Id)
                .Index(t => t.Worker_Id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NewTasks", "Worker_Id", "dbo.Workers");
            DropIndex("dbo.NewTasks", new[] { "Worker_Id" });
            DropTable("dbo.Workers");
            DropTable("dbo.NewTasks");
        }
    }
}
