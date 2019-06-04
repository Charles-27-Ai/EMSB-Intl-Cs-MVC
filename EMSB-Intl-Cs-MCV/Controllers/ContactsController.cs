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
        public ActionResult AdminTechnicians()
        {
            List<Contact> adminTech = new List<Contact>();

            adminTech.Add(new Contact()
            {
                Name = "Ms. Natasha Gillespie",
                Post = "Working at the EMSB headquarter, Administrative Technicians are in charge of processing the applications documents of all international students and provide Letter of Acceptance for them to apply for the CAQ and Study Permit form the government.",
                Email = "ngillespie@emsb.qc.ca",
                Phone = "(514) 483-7200 ext. 7259",
                Schools = new string[]
                {
                    "F.A.C.E. School, ",
                    "James Lyng High School, ",
                    "John F. Kennedy High School, ",
                    "John Paul I High School, ",
                    "Lester B. Pearson High School, ",
                    "Westmount High School"
                },
                Icon = "/Assets/Images/staff/staff-2.png",
                collapseName = "ngillespie"
            });

            adminTech.Add(new Contact()
            {
                Name = "Ms. Jeanine Lason",
                Post = "Working at the EMSB headquarter, Administrative Technicians are in charge of processing the applications documents of all international students and provide Letter of Acceptance for them to apply for the CAQ and Study Permit form the government.",
                Email = "jlason@emsb.qc.ca",
                Phone = "(514) 483-7200 ext. 7259",
                Schools = new string[]
                {
                    "LaurenHill Academy, ",
                    "LaurenHill Junior Campus, ",
                    "Marymount Academy, ",
                    "Rosemount High School, ",
                    "Royal West Academy, ",
                    "Royal Vale School, ",
                    "Vincent Massey Collegiate"
                },
                Icon = "/Assets/Images/staff/staff-3.png",
                collapseName = "jlason"
            });

            return PartialView("_AdminTech", adminTech);
        }

        //Column 2 (Advisors)
        public ActionResult Advisors()
        {
            List<Contact> advisor = new List<Contact>();

            advisor.Add(new Contact()
            {
                Name = "Mr. Charles Ai",
                Post = "On behalf of EMSB Youth Sector, Facilitators (Advisors) for International Students work at the EMSB high schools and collaborate with school administrators and staff to cater for all kinds of needs from our fee-paying international students (those who pay tuition fees).",
                Email = "kai@emsb.qc.ca",
                Phone = "(514) 483-7200 ext. 7788",
                Schools = new string[]
                {
                    "F.A.C.E. School, ",
                    "James Lyng High School, ",
                    "Laurier MacDonald High School, ",
                    "Lester B. Pearson High School, ",
                    "Rosemount High School, ",
                    "Vincent Massey Collegiate, ",
                    "Royal West Academy"
                },
                Icon = "/Assets/Images/staff/staff-4.png",
                collapseName = "charlesai"
            });

            advisor.Add(new Contact()
            {
                Name = "Ms. Ping Ji",
                Post = "On behalf of EMSB Youth Sector, Facilitators (Advisors) for International Students work at the EMSB high schools and collaborate with school administrators and staff to cater for all kinds of needs from our fee-paying international students (those who pay tuition fees).",
                Email = "pji@emsb.qc.ca",
                Phone = "(514) 483-7200 ext. 7788",
                Schools = new string[]
                {
                    "LaurenHill Junior Campus, ",
                    "Westmount High School"
                },
                Icon = "/Assets/Images/staff/staff-5.png",
                collapseName = "pingji"
            });

            advisor.Add(new Contact()
            {
                Name = "Ms. Angela Kim",
                Post = "On behalf of EMSB Youth Sector, Facilitators (Advisors) for International Students work at the EMSB high schools and collaborate with school administrators and staff to cater for all kinds of needs from our fee-paying international students (those who pay tuition fees).",
                Email = "ckim@emsb.qc.ca",
                Phone = "(514) 483-7200 ext. 7788",
                Schools = new string[]
                {
                    "John F. Kennedy High School, ",
                    "LaurenHill Academy, ",
                    "Laurier MacDonald High School, ",
                    "Marymount Academy"
                },
                Icon = "/Assets/Images/staff/staff-6.png",
                collapseName = "angelakim"
            });

            return PartialView("_Advisor", advisor);
        }
    }
}