namespace Election_Hackathon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addinglist : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Candidate_Registration_Form", "Post_Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Candidate_Registration_Form", "Post_Name", c => c.String());
        }
    }
}
