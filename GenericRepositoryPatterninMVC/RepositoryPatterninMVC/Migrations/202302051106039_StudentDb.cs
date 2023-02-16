namespace RepositoryPatterninMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Sid = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        MobileNo = c.String(),
                        Fees = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Sid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
