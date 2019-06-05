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
            myModel.Links = generateFieldTripList();
            return View(myModel);

        }

        private List<StudentList> generateFieldTripList()
        {
            List<StudentList> ftLists = new List<StudentList>();

            ftLists.Add(new StudentList()
            {
                LinkHeading = "Field Trip Registration Form",
                LinkIcon = "/Assets/Images/fieldTrips/ft-registration.png",
                LinkText = "Registration",
                LinkUrl = "/Assets/Pdfs/studentDocs/EMSB-Field-Trip-Registration-Form-18-19.pdf"
            });

            ftLists.Add(new StudentList()
            {
                LinkHeading = "Frequently Asked Questions",
                LinkIcon = "/Assets/Images/fieldTrips/ft-faq.png",
                LinkText = "FAQ",
                LinkUrl = "/Assets/Pdfs/studentDocs/EMSB-Field-Trip-Registration-Form-18-19.pdf"
            });

            return ftLists;
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
                Route = "/Students/StudyAssist",
                Url = "/Assets/Images/students-study-deselected.png",
                Class = "mt-2 mr-2 student-categories-text"
            });
            ftTitles.Add(new StudentTitle()
            {
                Name = "Health Support",
                Route = "/Students/HealthSupport",
                Url = "/Assets/Images/students-health-deselected.png",
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
                Heading = "Sugar Shack",
                HeadingFont = "students-card-heading",
                SubTitle = "Sucrie de la Montagne, Québec"
            });

            return ftCards;
        }


        public ActionResult StudyAssist()
        {
            dynamic myModel = new System.Dynamic.ExpandoObject();
            myModel.Titles = generateStudyTitle();
            myModel.Cards1 = generateStudyCardRow1();
            myModel.Cards2 = generateStudyCardRow2();
            myModel.Links = generateStudyList();
            return View(myModel);
        }

        private List<StudentTitle> generateStudyTitle()
        {
            List<StudentTitle> stTitles = new List<StudentTitle>();

            stTitles.Add(new StudentTitle()
            {
                Name = "Field Trips",
                Route = "/Students/Fieldtrips",
                Url = "/Assets/Images/students-bus-deselected.png",
                Class = "mt-2 mr-2 student-categories-text"
            });
            stTitles.Add(new StudentTitle()
            {
                Name = "Study Assist",
                Route = "/Students/StudyAssist",
                Url = "/Assets/Images/students-study-selected.png",
                Class = "mt-2 mr-2"
            });
            stTitles.Add(new StudentTitle()
            {
                Name = "Health Support",
                Route = "/Students/HealthSupport",
                Url = "/Assets/Images/students-health-deselected.png",
                Class = "mt-2 mr-2 student-categories-text"
            });
            return stTitles;
        }

        private List<StudentCard> generateStudyCardRow1()
        {
            List<StudentCard> htCards = new List<StudentCard>();

            htCards.Add(new StudentCard()
            {
                RouteName = "https://www.rosettastone.com",
                ImgUrl = "/Assets/Images/studyAssist/study-rosetta.jpg",
                IconUrl = "/Assets/Images/studyAssist/study-rosetta-icon.png",
                AltText = "Rosetta Stone",
                Heading = "Learn English/French in Rosetta Stone®",
                HeadingFont = "student-study-health-heading",
                SubTitle = "With free full-access licence from EMSBc"
            });

            return htCards;
        }

        private List<StudentCard> generateStudyCardRow2()
        {
            List<StudentCard> stCards2 = new List<StudentCard>();

            stCards2.Add(new StudentCard()
            {
                RouteName = "https://www.learnquebec.ca/home",
                ImgUrl = "/assets/images/studyAssist/study-learnQc.jpg",
                IconUrl = "/assets/images/studyAssist/study-learnQc-icon.png",
                AltText = "LEARN Quebec",
                Heading = "Online Tutoring on LEARN Quebec",
                HeadingFont = "student-study-health-heading",
                SubTitle = "In all subjects from Grade 7 to 11"
            });

            stCards2.Add(new StudentCard()
            {
                RouteName = "https://vitalenglish.com/",
                ImgUrl = "/assets/images/studyAssist/study-vitalEn.jpg",
                IconUrl = "/assets/images/studyAssist/study-vitalEn-icon.png",
                AltText = "Vital English",
                Heading = "Improve English on Vital English",
                HeadingFont = "student-study-health-heading",
                SubTitle = "With certificate programs"
            });
            return stCards2;
        }

        private List<StudentList> generateStudyList()
        {
            List<StudentList> stLists = new List<StudentList>();

            stLists.Add(new StudentList()
            {
                LinkUrl = "#",
                LinkIcon = "/Assets/Images/studyAssist/study-rosetta-demo.png",
                LinkText = "Rosetta demo",
                LinkHeading = "View Video Demo"
                
            });

            stLists.Add(new StudentList()
            {
                LinkUrl = "#",
                LinkIcon = "/Assets/Images/studyAssist/study-check-licence.png",
                LinkText = "Check licence",
                LinkHeading = "Check Your EMSB Free Licence"
            });

            stLists.Add(new StudentList()
            {
                LinkUrl = "#",
                LinkIcon = "/Assets/Images/studyAssist/study-web.png",
                LinkText = "Web portal",
                LinkHeading = "Log in from desktop version"
            });

            stLists.Add(new StudentList()
            {
                LinkUrl = "#",
                LinkIcon = "/Assets/Images/studyAssist/study-app-store.png",
                LinkText = "iOS download",
                LinkHeading = "Download from Apple App Store"
            });

            stLists.Add(new StudentList()
            {
                LinkUrl = "#",
                LinkIcon = "/Assets/Images/studyAssist/study-google-play.png",
                LinkText = "Android download",
                LinkHeading = "Download from Google Play"
            });
            return stLists;
        }

        // 改用 return Partial View 的形式独立 render Partial View
        public ActionResult HealthCard1()
        {
            List<StudentCard> htCards = new List<StudentCard>();

            htCards.Add(new StudentCard()
            {
                RouteName = "https://www.guard.me",
                ImgUrl = "/Assets/Images/healthSupport/health-guardMe.jpg",
                IconUrl = "/Assets/Images/healthSupport/health-guardMe-icon.png",
                AltText = "Guard.Me",
                Heading = "Guard.me Health Insurance",
                HeadingFont = "student-study-health-heading",
                SubTitle = "Protect health of all international students"
            });

            return PartialView("_HealthCard", htCards);
        }

        public ActionResult HealthCard2()
        {
            List<StudentCard> htCards = new List<StudentCard>();

            htCards.Add(new StudentCard()
            {
                RouteName = "https://keepmesafe.myissp.com",
                ImgUrl = "/Assets/Images/healthSupport/health-mental-1.jpg",
                IconUrl = "/Assets/Images/healthSupport/health-mental-icon.png",
                AltText = "Keep.meSAFE",
                Heading = "Keep.me Safe Multilingual Support",
                HeadingFont = "student-study-health-heading",
                SubTitle = "Help int'l students overcome life challenges"
            });

            return PartialView("_HealthCard", htCards);
        }

        public ActionResult HealthLink1()
        {
            List<StudentList> htLinks = new List<StudentList>();

            htLinks.Add(new StudentList()
            {
                LinkUrl = "#",
                LinkIcon = "/Assets/Images/healthSupport/health-clinique-icon.png",
                LinkText = "Clinic",
                LinkHeading = "Find a Nearby Clinic"
                
            });

            htLinks.Add(new StudentList()
            {
                LinkUrl = "#",
                LinkIcon = "/Assets/Images/healthSupport/health-claim-icon.png",
                LinkText = "Claim",
                LinkHeading = "Make a Claim After Clinic Visit"
            });

            return PartialView("_HealthLink", htLinks);
        }

        public ActionResult HealthLink2()
        {
            List<StudentList> htLinks = new List<StudentList>();

            htLinks.Add(new StudentList()
            {
                LinkUrl = "#",
                LinkIcon = "/Assets/Images/healthSupport/health-mySSP-icon.png",
                LinkText = "mySSP",
                LinkHeading = "Download My SSP App from App Store"
                
            });

            htLinks.Add(new StudentList()
            {
                LinkUrl = "#",
                LinkIcon = "/Assets/Images/healthSupport/health-call-icon.png",
                LinkText = "Hot line",
                LinkHeading = "Call an Advisor fro Help from Canada"
            });

            return PartialView("_HealthLink", htLinks);
        }

        
        public ActionResult HealthSupport()
        {
            return View();
        }

        public ActionResult HealthTitle()
        {
            List<StudentTitle> htTitles = new List<StudentTitle>();

            htTitles.Add(new StudentTitle()
            {
                Name = "Field Trips",
                Route = "/Students/Fieldtrips",
                Url = "/Assets/Images/students-bus-deselected.png",
                Class = "mt-2 mr-2 student-categories-text"
            });
            htTitles.Add(new StudentTitle()
            {
                Name = "Study Assist",
                Route = "/Students/StudyAssist",
                Url = "/Assets/Images/students-study-deselected.png",
                Class = "mt-2 mr-2 student-categories-text"
            });
            htTitles.Add(new StudentTitle()
            {
                Name = "Health Support",
                Route = "/Students/HealthSupport",
                Url = "/Assets/Images/students-health-selected.png",
                Class = "mt-2 mr-2"
            });

            return PartialView("_HealthTitle", htTitles);
        }

        // 以下内容暂时作废 The codes below are useless for now.
        private List<StudentTitle> generateHealthTitle()
        {
            List<StudentTitle> htTitles = new List<StudentTitle>();

            htTitles.Add(new StudentTitle()
            {
                Name = "Field Trips",
                Route = "/Students/Fieldtrips",
                Url = "/Assets/Images/students-bus-deselected.png",
                Class = "mt-2 mr-2 student-categories-text"
            });
            htTitles.Add(new StudentTitle()
            {
                Name = "Study Assist",
                Route = "/Students/StudyAssist",
                Url = "/Assets/Images/students-bus-deselected.png",
                Class = "mt-2 mr-2 student-categories-text"
            });
            htTitles.Add(new StudentTitle()
            {
                Name = "Health Support",
                Route = "/Students/HealthSupport",
                Url = "/Assets/Images/students-bus-selected.png",
                Class = "mt-2 mr-2"
            });
            return htTitles;
        }

        private List<StudentCard> generateHealthCard1()
        {
            List<StudentCard> htCards = new List<StudentCard>();

            htCards.Add(new StudentCard()
            {
                RouteName = "https://www.guard.me",
                ImgUrl = "/Assets/Images/healthSupport/health-guardMe.jpg",
                IconUrl = "/Assets/Images/healthSupport/health-guardMe-icon.png",
                AltText = "Guard.Me",
                Heading = "Guard.me Health Insurance",
                HeadingFont = "student-study-health-heading",
                SubTitle = "Protect health of all international students"
            });

            return htCards;
        }
        
        private List<StudentCard> generateHealthCard2()
        {
            List<StudentCard> htCards = new List<StudentCard>();

            htCards.Add(new StudentCard()
            {
                RouteName = "https://keepmesafe.myissp.com",
                ImgUrl = "/Assets/Images/healthSupport/health-mental.jpg",
                IconUrl = "/Assets/Images/healthSupport/health-mental-icon.png",
                AltText = "Keep.meSAFE",
                Heading = "Keep.me Safe Multilingual Support",
                HeadingFont = "student-study-health-heading",
                SubTitle = "Help int'l students overcome life challenges"
            });

            return htCards;
        }

        

        private List<StudentList> generateHealthLink1()
        {
            List<StudentList> htLinks = new List<StudentList>();

            htLinks.Add(new StudentList()
            {
                LinkUrl = "#",
                LinkIcon = "/Assets/Images/healthSupport/health-clinique-icon.png",
                LinkText = "Clinic",
                LinkHeading = "Find a Nearby Clinic"
                
            });

            htLinks.Add(new StudentList()
            {
                LinkUrl = "#",
                LinkIcon = "/Assets/Images/healthSupport/health-claim-icon.png",
                LinkText = "Claim",
                LinkHeading = "Make a Claim After Clinic Visit"
            });

            return htLinks;
        }

        private List<StudentList> generateHealthLink2()
        {
            List<StudentList> htLinks = new List<StudentList>();

            htLinks.Add(new StudentList()
            {
                LinkUrl = "#",
                LinkIcon = "/Assets/Images/healthSupport/health-mySSP-icon.png",
                LinkText = "mySSP",
                LinkHeading = "Download My SSP App from App Store"
                
            });

            htLinks.Add(new StudentList()
            {
                LinkUrl = "#",
                LinkIcon = "/Assets/Images/healthSupport/health-call-icon.png",
                LinkText = "Hot line",
                LinkHeading = "Call an Advisor fro Help from Canada"
            });

            return htLinks;
        }

    }


}