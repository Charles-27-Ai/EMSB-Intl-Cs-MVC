using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EMSB_Intl_Cs_MCV.Models;

namespace EMSB_Intl_Cs_MCV.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Student
        public ActionResult FieldTrips()
        {
            return View();
        }

        // Field Trip 
        public ActionResult FieldTripsCard()
        {
            List<StudentCard> list = new List<StudentCard>();

            list.Add(new StudentCard
            {
                RouteName = "ziplining",
                ImgUrl = "/Assets/Images/fieldTrips/ziplining.jpg",
                IconUrl = "/Assets/Images/fieldTrips/ziplining-bg.png",
                AltText = "Ziplining",
                Heading = "Abraska Ziplining",
                HeadingFont = "students-card-heading",
                SubTitle = "Marieville, Québec"
            });

            list.Add(new StudentCard
            {
                RouteName = "skisnowboarding",
                ImgUrl = "/Assets/Images/fieldTrips/ski.jpg",
                IconUrl = "/Assets/Images/fieldTrips/ski-bg.png",
                AltText = "Ski",
                Heading = "Ski and Snowboarding",
                HeadingFont = "students-card-heading",
                SubTitle = "Mont Rinaud, Québec"
            });

            list.Add(new StudentCard
            {
                RouteName = "qccity",
                ImgUrl = "/assets/images/fieldTrips/qc-city.jpg",
                IconUrl = "/assets/images/fieldTrips/qc-city-bg.png",
                AltText = "QC City",
                Heading = "Québec City and Ice Hotel",
                HeadingFont = "students-card-heading",
                SubTitle = "Québec City, Québec"
            });

            list.Add(new StudentCard
            {
                RouteName = "sugarshack",
                ImgUrl = "/assets/images/fieldTrips/sugar-shack.jpg",
                IconUrl = "/assets/images/fieldTrips/sugar-shack-bg.png",
                AltText = "Sugar Shack",
                Heading = "Sugar Shackl",
                HeadingFont = "students-card-heading",
                SubTitle = "Sucrie de la Montagne, Québec"
            });

            return PartialView("_StudentCard", list);

        }

        public ActionResult StudyAssist()
        {
            return View();
        }

        public ActionResult HealthSupport()
        {
            return View();
        }
    }
}