namespace TestAutomationPlayground.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedClientTypeSeed : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT [dbo].[ClientTypes] ON");
            Sql("INSERT INTO ClientTypes(Id,Name) VALUES(1, 'Small')");
            Sql("INSERT INTO ClientTypes(Id,Name) VALUES(2,'Medium')");
            Sql("INSERT INTO ClientTypes(Id,Name) VALUES(3,'Big')");
            Sql("INSERT INTO ClientTypes(Id,Name) VALUES(4,'Yuge')");
            Sql("SET IDENTITY_INSERT [dbo].[ClientTypes] OFF");
        }
        
        public override void Down()
        {
        }
    }
}
