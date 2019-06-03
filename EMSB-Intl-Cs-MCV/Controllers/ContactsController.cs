using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EMSB_Intl_Cs_MCV.Models;

namespace EMSB_Intl_Cs_MCV.Controllers
{
    public class ContactsController : Controller
    {
        
        public ActionResult Contacts()
        {
            return View();
        }

        //Row 1 (Leader)
        public ActionResult Leader()
        {
            List<Contact> leader = new List<Contact>();

            leader.Add(new Contact()
            {
                Name = "Ms. Sandra Léveillé",
                Post = "Ms. Léveillé is the leader of School Organization - International Students",
                Email = "sleveille@emsb.qc.ca",
                Phone = "(514) 483-7200 ext. 7483",
                Schools = null,
                Icon = "/Assets/Images/staff/staff-1.png"
            });

            return PartialView("_Leader", leader);
        }

        //Column 1 (Admin Techs)
        //public ActionResult AdminTechnicians()
        //{

        //}

        //Column 2 (Advisors)
        //public ActionResult Advisors()
        //{

        //}
    }
}