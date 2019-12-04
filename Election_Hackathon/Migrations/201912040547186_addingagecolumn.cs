namespace Election_Hackathon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingagecolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidate_Registration_Form", "Age", c => c.Int(nullable: false));
            DropColumn("dbo.General_Details", "Age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.General_Details", "Age", c => c.Int(nullable: false));
            DropColumn("dbo.Candidate_Registration_Form", "Age");
        }
    }
}
