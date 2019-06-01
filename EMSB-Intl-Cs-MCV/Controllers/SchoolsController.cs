using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EMSB_Intl_Cs_MCV.Models;

namespace EMSB_Intl_Cs_MCV.Controllers
{
    public class SchoolsController : Controller
    {

        public ActionResult SchoolPickerRow1()
        {
            List<School> list = new List<School>();

            list.Add(new School
            {
                Name = "F.A.C.E. School",
                RouteName = "face",
                IconUrl = "/Assets/Images/schoolLogos/FACE.png",
                IconWidth = 120
            });

            list.Add(new School
            {
                Name = "James Lyng High School",
                RouteName = "jameslyng",
                IconUrl = "/Assets/Images/schoolLogos/JL.png",
                IconWidth = 120
            });

            list.Add(new School
            {
                Name = "John F. Kennedy School",
                RouteName = "johnfkennedy",
                IconUrl = "/Assets/Images/schoolLogos/JFK.png",
                IconWidth = 120
            });

            list.Add(new School
            {
                Name = "Lester B. Pearson School",
                RouteName = "leasterbpearson",
                IconUrl = "/Assets/Images/schoolLogos/LBP.jpg",
                IconWidth = 120
            });

            return PartialView("_PickerLogo", list);
        }

        public ActionResult SchoolPickerRow2()
        {
            List<School> list = new List<School>();

            list.Add(new School
            {
                Name = "LaurenHill Academy & LaurenHill Junior Campus",
                RouteName = "laurenhill",
                IconUrl = "/Assets/Images/schoolLogos/LHA.jpg",
                IconWidth = 120
            });

            list.Add(new School
            {
                Name = "John Paul I Junior High School",
                RouteName = "johnpauli",
                IconUrl = "/Assets/Images/schoolLogos/JP.jpg",
                IconWidth = 120
            });

            list.Add(new School
            {
                Name = "Laurier MacDonald High School",
                RouteName = "lauriermacdonald",
                IconUrl = "/Assets/Images/schoolLogos/LMac.jpg",
                IconWidth = 120
            });

            list.Add(new School
            {
                Name = "Marymount Academy",
                RouteName = "marymount",
                IconUrl = "/Assets/Images/schoolLogos/MM.png",
                IconWidth = 120
            });

            return PartialView("_PickerLogo", list);

        }

        public ActionResult SchoolPickerRow3()
        {
            List<School> list = new List<School>();

            list.Add(new School
            {
                Name = "Rosemount High School",
                RouteName = "rousemount",
                IconUrl = "/Assets/Images/schoolLogos/RM.jpg",
                IconWidth = 120
            });

            list.Add(new School
            {
                Name = "Royal Vale School",
                RouteName = "royalvale",
                IconUrl = "/Assets/Images/schoolLogos/RV.png",
                IconWidth = 120
            });

            list.Add(new School
            {
                Name = "Vincent Massey Collegiate",
                RouteName = "vincentmassey",
                IconUrl = "/Assets/Images/schoolLogos/VMC.jpg",
                IconWidth = 120
            });

            list.Add(new School
            {
                Name = "Westmount High School",
                RouteName = "westmount",
                IconUrl = "/Assets/Images/schoolLogos/WM.jpg",
                IconWidth = 120
            });

            return PartialView("_PickerLogo", list);
        }

        public ActionResult SchoolPickerRow4()
        {
            List<School> list = new List<School>();

            list.Add(new School
            {
                Name = "Royal West Academy",
                RouteName = "royalwest",
                IconUrl = "/Assets/Images/schoolLogos/RWA.jpg",
                IconWidth = 240
            });

            return PartialView("_PickerLogo", list);
        }

        public ActionResult AllSchools()
        {

            return View();
        }

        public ActionResult Face()
        {
            var faceSchool = new School()
            {
                Name = "F.A.C.E.School",
                ImgUrl = new string[] {
                "/Assets/Images/schools/FACE-0.jpg",
                "/Assets/Images/schools/FACE-0.jpg",
                "/Assets/Images/schools/FACE-0.jpg"
                    },
                Intro = "Fine Arts Core Education (FACE) High School is located north of Sherbrooke St. West and is accessible by bus, McGill Metro, and Central or Windsor Train Stations.",
                Address = "3449 University Street, Montreal, QC, H3A 2A8",
                Phone = "(514) 350-8899",
                Email = "face@emsb.qc.ca",
                Website = "http://face-english.csdm.ca",
                Philo = new string[]
                    {
                    "To combine academic and artistic development which provides our students with many challenges in which they can flourish and develop their full potential.",
                    "To teach our important values which are openess of mind, respect, responsibility, independence, self-discipline, accomplishment and self-esteem.",
                    "To develop respect for others, an appreciation for the many facets of the world, an open mind, a more active vision of life, teamwork, and to foster intellectual, emotional, and spiritual growth."
                }
            };

            return View(faceSchool);
        }
    }
}