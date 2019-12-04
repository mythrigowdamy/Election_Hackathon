using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Election_Hackathon.Models
{
    public class Election_Result
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int NumberOfVotes { get; set; }
        public Candidate_Registration_Form Candidate_Registration_Form { get; set; }
        public int Candidate_Registration_FormId { get; set; }

    }
}