namespace Election_Hackathon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingvalidationtogeneral : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.General_Details", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.General_Details", "Register_Id", c => c.String(nullable: false));
            AlterColumn("dbo.General_Details", "UserName", c => c.String(nullable: false));
            AlterColumn("dbo.General_Details", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.General_Details", "Password", c => c.String());
            AlterColumn("dbo.General_Details", "UserName", c => c.String());
            AlterColumn("dbo.General_Details", "Register_Id", c => c.String());
            AlterColumn("dbo.General_Details", "Name", c => c.String());
        }
    }
}
