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
        // Set Zipling Page Info
        public ActionResult Ziplining()
        {
            dynamic myModel = new System.Dynamic.ExpandoObject();
            myModel.Titles = generateFieldTripTitle();
            myModel.Details = generateZipliningDetail();
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

        private List<FieldTripDetail> generateZipliningDetail()
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

        //Set Skiing Page Info
        public ActionResult Ski()
        {
            dynamic myModel = new System.Dynamic.ExpandoObject();
            myModel.Titles = generateFieldTripTitle();
            myModel.Details = generateSkiDetail();
            return View(myModel);
        }

        private List<FieldTripDetail> generateSkiDetail()
        {
            List<FieldTripDetail> skiDetail = new List<FieldTripDetail>();

            skiDetail.Add(new FieldTripDetail()
            {
                TripName = "Ski and Snowboarding Trip",
                TripIntro = "Every winter, we are leading the international students to learn and practice two essential winter sports in Canada – skiing and snowboarding – on pedagogical days at Mont Rigaud. From beginners to skilled players, all students can have a lot of fun on the different levels of the ski lanes.",
                ImgUrl = new string[]
                {
                    "/Assets/Images/schools/FACE-0.jpg",
                    "/Assets/Images/schools/FACE-1.jpg",
                    "/Assets/Images/schools/FACE-2.jpg",
                    "/Assets/Images/schools/FACE-3.jpg"
                },
                IntroIcon = "/Assets/Images/fieldTrips/ft-ski-intro.png",
                Location = "321 des Erables, Rigau, QC, J0P 1P0",
                DateTime = "1st: Feb 22; 2nd: Mar 1, 2019 at 8:30 am",
                MeetingPoint = "1st: John F. Kennedy High School Front Entrance; 2nd: Westmount High School Front Entrance",
                Transport = "School Bus",
                Back = "Same day, approximately 5:00 pm",
                ToBring = "Lunch, snacks; Bottles of water",
                ToWear = "Snow pants (water-proof), snow gloves (water-proof), skiing goggles (optional)",
                Schedule = new string[]
                {
                    "08:30 Departure from school",
                    "09:45 Arrival at Rigaud",
                    "10:00 – 11:00 Ski lesson for beginners",
                    "12:00 Lunch on site (bought at the cafeteria)",
                    "15:00 Return rented equipment",
                    "15:30 Departure from Rigaud to school",
                    "16:00 Estimated arrival at school"
                }
            });
            return skiDetail;
        }

        public ActionResult QcCity()
        {
            dynamic myModel = new System.Dynamic.ExpandoObject();
            myModel.Titles = generateFieldTripTitle();
            myModel.Details = generateQcCityDetail();
            return View(myModel);
        }

        private List<FieldTripDetail> generateQcCityDetail()
        {
            List<FieldTripDetail> qcDetail = new List<FieldTripDetail>();

            qcDetail.Add(new FieldTripDetail()
            {
                TripName = "Quebec City and Ice Hotel Trip",
                TripIntro = "Quebec City sits on the Saint Lawrence River in Canada's mostly French-speaking Quebec province. Dating to 1608, it has a fortified colonial core, Vieux-Québec and Place Royale, with very European style stone buildings and narrow streets.",
                ImgUrl = new string[]
                {
                    "/Assets/Images/schools/FACE-0.jpg",
                    "/Assets/Images/schools/FACE-1.jpg",
                    "/Assets/Images/schools/FACE-2.jpg",
                    "/Assets/Images/schools/FACE-3.jpg"
                },
                IntroIcon = "/Assets/Images/fieldTrips/ft-qc-intro.png",
                Location = "Old-Quebec, Quebec City, QC",
                DateTime = "Saturday Mar 16, 2019 at 7:00 am",
                MeetingPoint = "Westmount High School Front Entrance",
                Transport = "Coach Bus",
                Back = "Same day, approximately 8:00 pm",
                ToBring = "Lunch, snacks; Bottles of water; Snow pants; Water-resistent gloves (for Ice Hotel and Tubing)",
                ToWear = "Comfortable clothes with multiple layerse; Snow boots",
                Schedule = new string[]
                {
                    "07:00 Departure from school",
                    "09:30 Arrival at Ice Hotel",
                    "11:00 Play ice-tubing, lunch on site",
                    "13:30 Travel to Old-Quebec",
                    "15:00 Dinner at Restaurant Côtes-à-Côtes (paid by EMSB)",
                    "17:30 Leave for Montreal",
                    "20:00 Estimated arrival at school"
                }
            });
            return qcDetail;
        }

        public ActionResult SugarShack()
        {
            dynamic myModel = new System.Dynamic.ExpandoObject();
            myModel.Titles = generateFieldTripTitle();
            myModel.Details = generateSugarShackDetail();
            return View(myModel);
        }

        private List<FieldTripDetail> generateSugarShackDetail()
        {
            List<FieldTripDetail> sugarDetail = new List<FieldTripDetail>();

            sugarDetail.Add(new FieldTripDetail()
            {
                TripName = "Sugar Shack Trip",
                TripIntro = "A sugar shack (French: cabane à sucre), a.k.a. sugar house, is a semi-commercial establishment, primarily found in Eastern Canada. They are small cabins or groups of cabins where sap collected from sugar maple trees is boiled into maple syrup. Today many sugar shacks are commercially operated and also offer reception halls and outdoor activities open to the general public during certain months. Many of these activities include sleigh-riding, tours of the grounds, and eating maple toffee made in the house often in front of custormers.",
                ImgUrl = new string[]
                {
                    "/Assets/Images/schools/FACE-0.jpg",
                    "/Assets/Images/schools/FACE-1.jpg",
                    "/Assets/Images/schools/FACE-2.jpg",
                    "/Assets/Images/schools/FACE-3.jpg"
                },
                IntroIcon = "/Assets/Images/fieldTrips/ft-sugar-intro.png",
                Location = "300 Chemin Saint-Georges, Rigaud, QC",
                DateTime = "1st: March 29; 2nd: April 5, 2019 at 9:30 am",
                MeetingPoint = "1st: John F. Kennedy High School; 2nd: Westmount High School",
                Transport = "School Bus",
                Back = "Same day, approximately 3:00 pm",
                ToBring = "Snacks; Bottles of water",
                ToWear = "Spring clothes",
                Schedule = new string[]
                {
                    "09:30 Departure from school",
                    "10:30 Arrival at Sugar Shack",
                    "11:00 Tractor ride",
                    "11:30 Lunch on site (paid by EMSB)",
                    "12:30 Walk around and visit the Maple Syrup Factory",
                    "14:00 Departure from Rigaud to school",
                    "15:00 Estimated arrival at school"
                }
            });
            return sugarDetail;
        }
    }
}