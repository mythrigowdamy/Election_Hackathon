//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Election_Hackathon.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Candidate_Registration_Form
    {
        public int Id { get; set; }
        public string Candidate_Name { get; set; }
        public string Eduction_Qualification { get; set; }
        public string Current_Occupation { get; set; }
        public string Previous_RWA_Member { get; set; }
        public string Part_Of_GovtorPoliceorNGO { get; set; }
        public string Criminal_Record { get; set; }
        public int GeneralDetailsId { get; set; }
        public Nullable<int> General_Details_Id { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Post_Name { get; set; }
    
        public virtual General_Details General_Details { get; set; }
        public int NumberOfVotes { get; set; }
    }
}
