namespace Election_Hackathon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingvalidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Candidate_Registration_Form", "Gender", c => c.String(nullable: false));
            AlterColumn("dbo.Candidate_Registration_Form", "Eduction_Qualification", c => c.String(nullable: false));
            AlterColumn("dbo.Candidate_Registration_Form", "Current_Occupation", c => c.String(nullable: false));
            AlterColumn("dbo.Candidate_Registration_Form", "Previous_RWA_Member", c => c.String(nullable: false));
            AlterColumn("dbo.Candidate_Registration_Form", "Part_Of_GovtorPoliceorNGO", c => c.String(nullable: false));
            AlterColumn("dbo.Candidate_Registration_Form", "Criminal_Record", c => c.String(nullable: false));
            AlterColumn("dbo.Candidate_Registration_Form", "Post_Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Candidate_Registration_Form", "Post_Name", c => c.String());
            AlterColumn("dbo.Candidate_Registration_Form", "Criminal_Record", c => c.String());
            AlterColumn("dbo.Candidate_Registration_Form", "Part_Of_GovtorPoliceorNGO", c => c.String());
            AlterColumn("dbo.Candidate_Registration_Form", "Previous_RWA_Member", c => c.String());
            AlterColumn("dbo.Candidate_Registration_Form", "Current_Occupation", c => c.String());
            AlterColumn("dbo.Candidate_Registration_Form", "Eduction_Qualification", c => c.String());
            AlterColumn("dbo.Candidate_Registration_Form", "Gender", c => c.String());
        }
    }
}
