namespace ProjectASPWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUserModel : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Users");
            AddColumn("dbo.Users", "UserID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Users", "UserName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Users", "UserPassword", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Users", "UserRole", c => c.String(nullable: false, maxLength: 1));
            AddColumn("dbo.Users", "UserImg", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Users", "UpdDate", c => c.DateTime(nullable: false));
            AddPrimaryKey("dbo.Users", "UserID");
            DropColumn("dbo.Users", "Id");
            DropColumn("dbo.Users", "FirstName");
            DropColumn("dbo.Users", "LastName");
            DropColumn("dbo.Users", "Email");
            DropColumn("dbo.Users", "Password");
            DropColumn("dbo.Users", "UpdatedAt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "UpdatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 70));
            AddColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 70));
            AddColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Users");
            DropColumn("dbo.Users", "UpdDate");
            DropColumn("dbo.Users", "UserImg");
            DropColumn("dbo.Users", "UserRole");
            DropColumn("dbo.Users", "UserPassword");
            DropColumn("dbo.Users", "UserName");
            DropColumn("dbo.Users", "UserID");
            AddPrimaryKey("dbo.Users", "Id");
        }
    }
}
