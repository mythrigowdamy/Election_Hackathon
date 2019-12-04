using Election_Hackathon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Election_Hackathon.Controllers
{
    public class ElectionController : Controller
    {
        private ApplicationDbContext _context = null;
            public ElectionController()
        {
            _context = new ApplicationDbContext();  
        }
        // GET: Election
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterNew(Candidate_Registration_Form register)
        {
            if (!ModelState.IsValid)
            {
                return View( register);           
            }
            if (register.Id == 0)
            {
                _context.candidate_Registration_Forms.Add(register);
                _context.SaveChanges();
                return RedirectToAction("Index", "Election");
            }
            return Content("Internal error");
        }
        
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var log = _context.General_Details.FirstOrDefault(c => c.UserName == username && c.Password == password);
            if (log == null)
            {
                return Content("login failed");
            }
            else
                return RedirectToAction("BallotPaper","Election");
        }
        [HttpGet]
        public ActionResult BallotPaper()
        {

            var ppl = _context.candidate_Registration_Forms.ToList();
            if (ppl == null)
            {
                return Content("No Candidates for election");
            }
            else
                return View(ppl);
        }
        [HttpPost]
        public ActionResult BallotPaper(int id)
        {

            var res = _context.candidate_Registration_Forms.FirstOrDefault(c => c.Id == id);
            if(res!=null)
            {
                res.NumberOfVotes++;
                _context.SaveChanges();
                return RedirectToAction("Index", "Election");
               
            }
            else
                return Content("No Votes");
        }



    }
}