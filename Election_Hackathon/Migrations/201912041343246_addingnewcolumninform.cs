namespace Election_Hackathon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingnewcolumninform : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidate_Registration_Form", "NumberOfVotes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Candidate_Registration_Form", "NumberOfVotes");
        }
    }
}
