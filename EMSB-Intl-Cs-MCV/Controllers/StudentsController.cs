using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using EMSB_Intl_Cs_MCV.Models;
using Microsoft.Win32;

namespace EMSB_Intl_Cs_MCV.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Student
        public ActionResult FieldTrips()
        {
            
            dynamic myModel = new System.Dynamic.ExpandoObject();
            myModel.Titles = generateFieldTripTitle();
            myModel.Cards = generateFieldTripCard();
            return View(myModel);

        }

        private List<StudentTitle> generateFieldTripTitle()
        {
            List<StudentTitle> ftTitles = new List<StudentTitle>();

            ftTitles.Add(new StudentTitle()
            {
                Name = "Field Trips",
                Route = "/Students/Fieldtrips",
                Url = "/Assets/Images/students-bus-selected.png",
                Class = "mt-2 mr-2"
            });
            ftTitles.Add(new StudentTitle()
            {
                Name = "Study Assist",
                Route = "/Students/Study",
                Url = "/Assets/Images/students-bus-deselected.png",
                Class = "mt-2 mr-2 student-categories-text"
            });
            ftTitles.Add(new StudentTitle()
            {
                Name = "Health Support",
                Route = "/Students/Health",
                Url = "/Assets/Images/students-bus-deselected.png",
                Class = "mt-2 mr-2 student-categories-text"
            });
            return ftTitles;
        }

        private List<StudentCard> generateFieldTripCard()
        {
            List<StudentCard> ftCards = new List<StudentCard>();

            ftCards.Add(new StudentCard()
            {
                RouteName = "Ziplining",
                ImgUrl = "/Assets/Images/fieldTrips/ziplining.jpg",
                IconUrl = "/Assets/Images/fieldTrips/ziplining-bg.png",
                AltText = "Ziplining",
                Heading = "Abraska Ziplining",
                HeadingFont = "students-card-heading",
                SubTitle = "Marieville, Québec"
            });

            ftCards.Add(new StudentCard()
            {
                RouteName = "Ski",
                ImgUrl = "/Assets/Images/fieldTrips/ski.jpg",
                IconUrl = "/Assets/Images/fieldTrips/ski-bg.png",
                AltText = "Ski",
                Heading = "Ski and Snowboarding",
                HeadingFont = "students-card-heading",
                SubTitle = "Mont Rinaud, Québec"
            });

            ftCards.Add(new StudentCard()
            {
                RouteName = "Qccity",
                ImgUrl = "/assets/images/fieldTrips/qc-city.jpg",
                IconUrl = "/assets/images/fieldTrips/qc-city-bg.png",
                AltText = "QC City",
                Heading = "Québec City and Ice Hotel",
                HeadingFont = "students-card-heading",
                SubTitle = "Québec City, Québec"
            });

            ftCards.Add(new StudentCard()
            {
                RouteName = "Sugarshack",
                ImgUrl = "/assets/images/fieldTrips/sugar-shack.jpg",
                IconUrl = "/assets/images/fieldTrips/sugar-shack-bg.png",
                AltText = "Sugar Shack",
                Heading = "Sugar Shackl",
                HeadingFont = "students-card-heading",
                SubTitle = "Sucrie de la Montagne, Québec"
            });

            return ftCards;
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