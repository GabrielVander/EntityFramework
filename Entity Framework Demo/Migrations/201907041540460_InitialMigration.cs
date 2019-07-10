namespace Entity_Framework_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        code = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 2147483647),
                        location = c.String(maxLength: 2147483647),
                        phoneExtension = c.Int(nullable: false),
                        budget = c.Double(nullable: false),
                        chief_id = c.Long(),
                    })
                .PrimaryKey(t => t.code)
                .ForeignKey("dbo.Employees", t => t.chief_id)
                .Index(t => t.chief_id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        name = c.String(maxLength: 2147483647),
                        salary = c.Double(nullable: false),
                        jobTitle = c.String(maxLength: 2147483647),
                        dept_code = c.Int(),
                        deptInCharge_code = c.Int(),
                        Department_code = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Departments", t => t.dept_code)
                .ForeignKey("dbo.Departments", t => t.deptInCharge_code)
                .ForeignKey("dbo.Departments", t => t.Department_code)
                .Index(t => t.dept_code)
                .Index(t => t.deptInCharge_code)
                .Index(t => t.Department_code);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Department_code", "dbo.Departments");
            DropForeignKey("dbo.Departments", "chief_id", "dbo.Employees");
            DropForeignKey("dbo.Employees", "deptInCharge_code", "dbo.Departments");
            DropForeignKey("dbo.Employees", "dept_code", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Department_code" });
            DropIndex("dbo.Employees", new[] { "deptInCharge_code" });
            DropIndex("dbo.Employees", new[] { "dept_code" });
            DropIndex("dbo.Departments", new[] { "chief_id" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
