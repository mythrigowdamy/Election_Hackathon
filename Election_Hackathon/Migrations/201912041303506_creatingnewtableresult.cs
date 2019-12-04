namespace Election_Hackathon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creatingnewtableresult : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Election_Result",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NumberOfVotes = c.Int(nullable: false),
                        Candidate_Registration_FormId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidate_Registration_Form", t => t.Candidate_Registration_FormId, cascadeDelete: true)
                .Index(t => t.Candidate_Registration_FormId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Election_Result", "Candidate_Registration_FormId", "dbo.Candidate_Registration_Form");
            DropIndex("dbo.Election_Result", new[] { "Candidate_Registration_FormId" });
            DropTable("dbo.Election_Result");
        }
    }
}
