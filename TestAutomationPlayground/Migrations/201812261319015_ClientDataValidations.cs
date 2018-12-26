namespace TestAutomationPlayground.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientDataValidations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "FirstName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Clients", "LastName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Clients", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "BirthDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Clients", "InsuranceNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "InsuranceNumber", c => c.String());
            AlterColumn("dbo.Clients", "BirthDate", c => c.String());
            AlterColumn("dbo.Clients", "Email", c => c.String());
            AlterColumn("dbo.Clients", "LastName", c => c.String());
            AlterColumn("dbo.Clients", "FirstName", c => c.String());
        }
    }
}
