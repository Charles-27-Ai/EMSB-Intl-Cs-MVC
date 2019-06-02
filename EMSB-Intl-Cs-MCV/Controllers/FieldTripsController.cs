using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EMSB_Intl_Cs_MCV.Models;
using Microsoft.Win32;
using System.Web.Mvc;

namespace EMSB_Intl_Cs_MCV.Controllers
{
    public class FieldTripsController : Controller
    {
        // GET: FieldTrip
        public ActionResult Ziplining()
        {
            dynamic myModel = new System.Dynamic.ExpandoObject();
            myModel.Titles = generateFieldTripTitle();
            myModel.Details = generateFieldTripDetail();
            return View(myModel);
        }

        private List<StudentTitle> generateFieldTripTitle()
        {
            List<StudentTitle> ftTitles = new List<StudentTitle>();

            ftTitles.Add(new StudentTitle()
            {
                Name = "Field Trips",
                Route = "/students/",
                Url = "/Assets/Images/students-bus-selected.png",
                Class = "mt-2 mr-2"
            });
            ftTitles.Add(new StudentTitle()
            {
                Name = "Study Assist",
                Route = "/students/study",
                Url = "/Assets/Images/students-bus-deselected.png",
                Class = "mt-2 mr-2 student-categories-text"
            });
            ftTitles.Add(new StudentTitle()
            {
                Name = "Health Support",
                Route = "/students/health",
                Url = "/Assets/Images/students-bus-deselected.png",
                Class = "mt-2 mr-2 student-categories-text"
            });
            return ftTitles;
        }

        private List<FieldTripDetail> generateFieldTripDetail()
        {
            List<FieldTripDetail> zipliningDetail = new List<FieldTripDetail>();

            zipliningDetail.Add(new FieldTripDetail()
            {
                TripName = "Abraska Ziplining Trip",
                TripIntro = "Ziplining is a fun activity you can practice in Canada during the summer or fall season. In Montreal area, there are several parks with treetop challenge games and zip line adventures that wil make you appreciate the beautiful summer and fall colors from different heights.",
                ImgUrl = new string[]
                {
                   "/assets/images/schools/FACE-0.jpg",
                   "/assets/images/schools/FACE-1.jpg",
                   "/assets/images/schools/FACE-2.jpg",
                   "/assets/images/schools/FACE-3.jpg"
                },
                IntroIcon = "/Assets/Images/fieldTrips/ft-ziplining-intro.png",
                Location = "45 Chemin du Sous-Bois, Mont St-Grégoire, QC",
                DateTime = "Monday Oct. 1, 2018 at 8:30 am",
                MeetingPoint = "Westmount High School Front Entrance",
                Transport = "School Bus",
                Back = "Same day, approximately 4:00 pm",
                ToBring = "Lunch, snacks; Bottles of water; A pair of thin gloves",
                ToWear = "Comfortable clothes with multiple layerse; Running shoes",
                Schedule = new string[]
                {
                    "08:30 Departure from school",
                    "09:45 Arrival at Rigaud",
                    "10:00 – 12:30 Ziplining",
                    "12:00 – 12:45 Lunch",
                    "12:45 – 14:45 Ziplining",
                    "15:00 Departure from Rigaud to school",
                    "16:00 Estimated arrival at school"
                }
            });
            return zipliningDetail;
        }
    }
}