namespace Election_Hackathon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingbacktostring : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidate_Registration_Form", "Post_Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Candidate_Registration_Form", "Post_Name");
        }
    }
}
