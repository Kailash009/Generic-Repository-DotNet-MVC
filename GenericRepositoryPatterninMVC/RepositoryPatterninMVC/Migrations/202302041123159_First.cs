namespace RepositoryPatterninMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Eid = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        MobileNo = c.String(),
                        Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Eid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
