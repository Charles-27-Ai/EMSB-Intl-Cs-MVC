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
                RouteName = "lesterbpearson",
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
                RouteName = "rosemount",
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
                Name = "F.A.C.E. School",
                ImgUrl = new string[] {
                "/Assets/Images/schools/FACE-0.jpg",
                "/Assets/Images/schools/FACE-1.jpg",
                "/Assets/Images/schools/FACE-2.jpg",
                "/Assets/Images/schools/FACE-3.jpg"
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

        public ActionResult JamesLyng()
        {
            var jlSchool = new School()
            {
                Name = "James Lyng High School",
                ImgUrl = new string[] {
                    "/Assets/Images/schools/FACE-0.jpg",
                    "/Assets/Images/schools/FACE-1.jpg",
                    "/Assets/Images/schools/FACE-2.jpg",
                    "/Assets/Images/schools/FACE-3.jpg"
                },
                Intro = "James Lyng High School is located in St. Henri, at the corner of Carillon Street and is accessible by regular bus, or an express bus to the school that operates during the early morning hours from the Lionel Groux Metro.",
                Address = "5440 Notre Dame Street West, Montreal, QC, H4C 1T9",
                Phone = "(514) 846-8814",
                Email = "jameslyng@emsb.qc.ca",
                Website = "http://jameslyng.emsb.qc.ca",
                Philo = new string[]
                {
                    "To provide a safe and welcoming atmosphere for all members of its community.",
                    "To teach our important values which are openess of mind, respect, responsibility, independence, self-discipline, accomplishment and self-esteem.",
                    "To develop respect for others, an appreciation for the many facets of the world, an open mind, a more active vision of life, teamwork, and to foster intellectual, emotional, and spiritual growth."
                }
            };
            return View(jlSchool);
        }

        public ActionResult JohnFKennedy()
        {
            var jfkSchool = new School()
            {
                Name = "John F. Kennedy High School",
                ImgUrl = new string[] {
                    "/Assets/Images/schools/FACE-0.jpg",
                    "/Assets/Images/schools/FACE-1.jpg",
                    "/Assets/Images/schools/FACE-2.jpg",
                    "/Assets/Images/schools/FACE-3.jpg"
                },
                Intro = "John F. Kennedy High School is located in the St. Michel area at the corner of Villeray Street and St. Michel Boulevard. It is accessible by bus or a short walk north from the St. Michel metro station.",
                Address = "3030 Villeray Street Montreal, QC, H2A 1E7",
                Phone = "(514) 374-1449",
                Email = "jfk@emsb.qc.ca",
                Website = "http://www.emsb.qc.ca/jfk",
                Philo = new string[]
                {
                    "To ensure that each student develops his/her skills to their fullest.",
                    "To challenge each student to realize their full potential intellectually, physically, and spiritually.",
                    "To provide an education that encourages creativity, the pursuit of knowledge, achievement, physical fitness and self-discipline."
                }
            };
            return View(jfkSchool);
        }

        public ActionResult LesterBPearson()
        {
            var lbpSchool = new School()
            {
                Name = "John F. Kennedy High School",
                ImgUrl = new string[] {
                    "/Assets/Images/schools/FACE-0.jpg",
                    "/Assets/Images/schools/FACE-1.jpg",
                    "/Assets/Images/schools/FACE-2.jpg",
                    "/Assets/Images/schools/FACE-3.jpg"
                },
                Intro = "Lester B. Pearson High School is located between Henri-Bourassa and Maurice-Duplessis and is accessible by bus and/or the Henri-Bourassa Metro.",
                Address = "11575 P.M. Favier Street, Montreal, QC, H2A 1E7",
                Phone = "(514) 328-4442",
                Email = "lesterbpearson@emsb.qc.ca",
                Website = "http://www.lesterbpearson.emsb.qc.ca",
                Philo = new string[]
                {
                    "To provide for the diverse needs of all students in an inclusive environment.",
                    "To develop responsible, self-reliant students who through their chosen pathway can make a positive contribution to society.",
                    "To encourage and promote the school\'s motto “Always Strive for Excellence."
                }
            };
            return View(lbpSchool);
        }

        public ActionResult LaurenHill()
        {
            var lrhSchool = new School()
            {
                Name = "LaurenHill Academy & LaurenHill Junior Campus",
                ImgUrl = new string[] {
                    "/Assets/Images/schools/FACE-0.jpg",
                    "/Assets/Images/schools/FACE-1.jpg",
                    "/Assets/Images/schools/FACE-2.jpg",
                    "/Assets/Images/schools/FACE-3.jpg"
                },
                Intro = "LaurenHill Academy is accessible by bus and/or the Cote Vertu Metro. Both campuses are within walking distance of each other.",
                Address = "LHA: 2505 Cote Vertu Road, Saint Laurent, QC, H4M 1C2; LHJC: 2355 Decelles Street, Saint Laurent, QC, H4R 1P3",
                Phone = "LHA: (514) 331-8019; LHJC: (514) 331-8781",
                Email = "LHA: laurenhillacademy@emsb.qc.ca; LHJC: laurenhillannex@emsb.qc.ca",
                Website = "http://laurenhill.emsb.qc.ca",
                Philo = new string[]
                {
                    "To guide students in their pursuit of academic excellence and .",
                    "To prepare students for the challenges of an ever-changing society.",
                    "To learn in a safe and civil environment in order to develop intellectually, physically and emotionally and to help students reach their full potential."
                }
            };
            return View(lrhSchool);
        }

        public ActionResult JohnPaulI()
        {
            var jpiSchool = new School()
            {
                Name = "John Paul I Junior High School",
                ImgUrl = new string[] {
                    "/Assets/Images/schools/FACE-0.jpg",
                    "/Assets/Images/schools/FACE-1.jpg",
                    "/Assets/Images/schools/FACE-2.jpg",
                    "/Assets/Images/schools/FACE-3.jpg"
                },
                Intro = "John Paul I Junior High School is located north of the Metropolitan Boulevard between Lacordaire and Viau. It is accessible by bus and/ or metro Cremazie,, Cadillac, or Viau.",
                Address = "8455 Pre-Laurin Street Saint Leonard, QC, H1R 3P3",
                Phone = "(514) 328-7171",
                Email = "johnpaul1@emsb.qc.ca",
                Website = "http://johnpauli.emsb.qc.ca",
                Philo = new string[]
                {
                    "To  students to grow intellectually and socially in an environment built upon personal strengths.",
                    "To provide a balanced educational curriculum for all in a three-fold process of a rigorous academic syllabus, a strict and consistent discipline policy and varied student life programs.",
                    "To learn in a safe and civil environment in order to develop intellectually, physically and emotionally and to achieve and learn self-esteem, self-worth and ownership."
                }
            };
            return View(jpiSchool);
        }

        public ActionResult LaurierMacdonald()
        {
            var lmacSchool = new School()
            {
                Name = "Laurier MacDonald High School",
                ImgUrl = new string[] {
                    "/Assets/Images/schools/FACE-0.jpg",
                    "/Assets/Images/schools/FACE-1.jpg",
                    "/Assets/Images/schools/FACE-2.jpg",
                    "/Assets/Images/schools/FACE-3.jpg"
                },
                Intro = "Laurier MacDonald is located on the corner of Jean Talon and Viau and is accessible by bus and/or the Viau Metro and the Saint Michel Metro.",
                Address = "7355 Viau Street, Saint Leonard, QC, H1S 3C2",
                Phone = "(514) 374-6000",
                Email = "lmacdonald@emsb.qc.ca",
                Website = "http://www.lauriermacdonald.ca",
                Philo = new string[]
                {
                    "To develop the talents and strengths of each student in a supportive environment where students are taught respect for individual differences and the rights of others.",
                    "To prepare students to become productive/responsible citizens and promote values such as honesty, respect, fairness and loyalty.",
                    "To develop a broad range of knowledge and skills in basic subject areas, communications, technology, logical thinking and problem solving."
                }
            };
            return View(lmacSchool);
        }

        public ActionResult Marymount()
        {
            var mmaSchool = new School()
            {
                Name = "Marymount Academy",
                ImgUrl = new string[] {
                    "/Assets/Images/schools/FACE-0.jpg",
                    "/Assets/Images/schools/FACE-1.jpg",
                    "/Assets/Images/schools/FACE-2.jpg",
                    "/Assets/Images/schools/FACE-3.jpg"
                },
                Intro = "Marymount Academy is east of Decarie Blvd. and is accessible by bus and/or the Villa Maria Metro.",
                Address = "5100 Cote St Luc Road, Montreal, QC, H3W 2G9",
                Phone = "(514) 488-8144",
                Email = "marymount@emsb.qc.ca",
                Website = "http://marymount.emsb.qc.ca",
                Philo = new string[]
                {
                    "To help promote to the fullest extent possible, the intellectual, social, moral and physical development of all its students.",
                    "To create a harmonious environment which encourages creativity, problem-solving and responsible citizenship.",
                    "To encourage academic excellence and instill values based on global humanism."
                }
            };
            return View(mmaSchool);
        }

        public ActionResult Rosemount()
        {
            var rmhSchool = new School()
            {
                Name = "Rosemount High School",
                ImgUrl = new string[] {
                    "/Assets/Images/schools/FACE-0.jpg",
                    "/Assets/Images/schools/FACE-1.jpg",
                    "/Assets/Images/schools/FACE-2.jpg",
                    "/Assets/Images/schools/FACE-3.jpg"
                },
                Intro = "Rosemount High School is located between 16th and 18th Avenues and is accessible by bus and/or the Beaubien or Pie IX Metro.",
                Address = "3737 Beaubien Street East, Montreal, QC, H1X 1H2",
                Phone = "(514) 488-8144",
                Email = "marymount@emsb.qc.ca",
                Website = "http://marymount.emsb.qc.ca",
                Philo = new string[]
                {
                    "To provide an environment where all students can find their abilities and realize their potential.",
                    "To provide a unique opportunity for students to benefit from a multi-disciplinary approach to learning and to encourage and commit to the academic excellence of its students.",
                    "To develop the students’ full artistic and musical abilities through advanced instrumental performance."
                }
            };
            return View(rmhSchool);
        }

        public ActionResult RoyalVale()
        {
            var rvSchool = new School()
            {
                Name = "Royal Vale School",
                ImgUrl = new string[] {
                    "/Assets/Images/schools/FACE-0.jpg",
                    "/Assets/Images/schools/FACE-1.jpg",
                    "/Assets/Images/schools/FACE-2.jpg",
                    "/Assets/Images/schools/FACE-3.jpg"
                },
                Intro = "Royal Vale High School is located at the corner of Somerled and Draper and is accessible by bus and/or the Vendome Metro/Train Station and the Snowdon Metro.",
                Address = "5851 Somerled Avenue, Montreal, QC, H3X 2A5",
                Phone = "(514) 481-2463",
                Email = "royalvale@emsb.qc.ca",
                Website = "http://royalvale.emsb.qc.ca",
                Philo = new string[]
                {
                    "To prepare our students for tomorrow\'s world through a challenging curriculum and extensive extra-curricular activities which provides our students the opportunity to assume leadership roles.",
                    "To provide a supportive atmosphere that encourages acceptance of, and respect for, others and oneself, democratic values and an understanding of the relationship of the individual, the school and the community.",
                    "To develop students\' cognitive skills, communication skills, and intellectual curiosity enabling them to become effective critical thinking and creative individuals."
                }
            };
            return View(rvSchool);
        }

        public ActionResult VincentMassey()
        {
            var vmcSchool = new School()
            {
                Name = "Vincent Massey Collegiate",
                ImgUrl = new string[] {
                    "/Assets/Images/schools/FACE-0.jpg",
                    "/Assets/Images/schools/FACE-1.jpg",
                    "/Assets/Images/schools/FACE-2.jpg",
                    "/Assets/Images/schools/FACE-3.jpg"
                },
                Intro = "Vincent Massey Collegiate (VMC) is located at the corner of 27th Avenue and Rosemount and is accessible by bus, the Pie IX Metro, the Rosemount and Langelier Metros, and an express bus in the afternoon from Vincent Massey Collegiate to Perras in Riviere-des-Prairies.",
                Address = "5925 27th Avenue Montreal, QC, H1T 3J5",
                Phone = "(514) 374-1999",
                Email = "vincentmassey@emsb.qc.ca",
                Website = "http://www.vmc.qc.ca",
                Philo = new string[]
                {
                    "To promote academic excellence.",
                    "To develop the well-rounded students committed to academic achievement and a sense of community responsibilities.",
                    "To achieve the goals of our students emphasis is placed on academic excellence, self-discipline and mandatory participation in a variety of school activities."
                }
            };
            return View(vmcSchool);
        }

        public ActionResult Westmount()
        {
            var wmSchool = new School()
            {
                Name = "Westmount High School",
                ImgUrl = new string[] {
                    "/Assets/Images/schools/FACE-0.jpg",
                    "/Assets/Images/schools/FACE-1.jpg",
                    "/Assets/Images/schools/FACE-2.jpg",
                    "/Assets/Images/schools/FACE-3.jpg"
                },
                Intro = "Westmount High School is located near the corner of Greene Avenue and is accessible by bus, the Atwater Metro, and/or the Vendome Metro/Train Station.",
                Address = "4350 St. Catherine Street West, Westmount, QC, H3Z 1R1",
                Phone = "(514) 933-2701",
                Email = "westmounthigh@emsb.qc.ca",
                Website = "https://duxvitaeratio.ca",
                Philo = new string[]
                {
                    "To create and maintain a safe and effective learning environment while encouraging self-expression, self-discipline and self-fulfillment.",
                    "To serve students\' needs while developing their self-discipline and respect for each other.",
                    "To provide an exceptional learning environment where students can explore their interests and reach their potential."
                }
            };
            return View(wmSchool);
        }

        public ActionResult RoyalWest()
        {
            var rwaSchool = new School()
            {
                Name = "Royal West Academy",
                ImgUrl = new string[] {
                    "/Assets/Images/schools/FACE-0.jpg",
                    "/Assets/Images/schools/FACE-1.jpg",
                    "/Assets/Images/schools/FACE-2.jpg",
                    "/Assets/Images/schools/FACE-3.jpg"
                },
                Intro = "Royal West Academy is located near the corner of Westminster and St. Jacques/Avon and is accessible by commuter train to the Montreal West Train Station, bus, and/or the Snowdon Metro, the Vendome Metro/Train Station, and the Villa Maria Metro.",
                Address = "4350 St. Catherine Street West, Westmount, QC, H3Z 1R1",
                Phone = "(514) 933-2701",
                Email = "westmounthigh@emsb.qc.ca",
                Website = "https://duxvitaeratio.ca",
                Philo = new string[]
                {
                    "To provide a structured milieu in which students are committed to academic achievement, bilingualism, computer literacy, an appreciation of the arts, an understanding of social issues and a sense of community responsibilities.",
                    "To encourage the development of self-discipline, learning and interpersonal skills, a strong sense of responsibility and self-esteem in the students.",
                    "To participate in the compulsory extra-curricular program that includes athletic, cultural, environmental, and community service activities as a means to promote personal development and physical well-being."
                }
            };
            return View(rwaSchool);
        }
    }
}