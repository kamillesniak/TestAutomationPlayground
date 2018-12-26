namespace TestAutomationPlayground.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clientstatuses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Clients", "IsSubsribedToNewsLetter", c => c.Boolean(nullable: false));
            AddColumn("dbo.Clients", "ClientStatusId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "ClientStatusId");
            AddForeignKey("dbo.Clients", "ClientStatusId", "dbo.ClientStatus", "Id", cascadeDelete: true);

            Sql("SET IDENTITY_INSERT [dbo].[ClientTypes] ON");
            Sql("INSERT INTO ClientStatus(Name) VALUES('Bronze')");
            Sql("INSERT INTO ClientStatus(Name) VALUES('Silver')");
            Sql("INSERT INTO ClientStatus(Name) VALUES('Gold')");
            Sql("SET IDENTITY_INSERT [dbo].[ClientTypes] OFF");

        }

        public override void Down()
        {
            DropForeignKey("dbo.Clients", "ClientStatusId", "dbo.ClientStatus");
            DropIndex("dbo.Clients", new[] { "ClientStatusId" });
            DropColumn("dbo.Clients", "ClientStatusId");
            DropColumn("dbo.Clients", "IsSubsribedToNewsLetter");
            DropTable("dbo.ClientStatus");
        }
    }
}
