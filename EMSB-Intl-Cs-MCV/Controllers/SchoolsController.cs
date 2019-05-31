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

        public ActionResult AllSchools()
        {

            var faceLogo = new School
            {
                Name = "F.A.C.E. School",
                RouteName = "face",
                IconUrl = "/Assets/Images/schoolLogos/FACE.png",
                IconWidth = 120
            };
            var jlLogo = new School
            {
                Name = "James Lyng High School",
                RouteName = "jameslyng",
                IconUrl = "/Assets/Images/schoolLogos/JL.png",
                IconWidth = 120
            };
            var jfkLogo = new School
            {
                Name = "John F. Kennedy School",
                RouteName = "johnfkennedy",
                IconUrl = "/Assets/Images/schoolLogos/JFK.png",
                IconWidth = 120
            };
            var lbpLogo = new School
            {
                Name = "Lester B. Pearson School",
                RouteName = "leasterbpearson",
                IconUrl = "/Assets/Images/schoolLogos/LBP.png",
                IconWidth = 120
            };
            var lhaLogo = new School
            {
                Name = "LaurenHill Academy & LaurenHill Junior Campus",
                RouteName = "laurenhill",
                IconUrl = "/Assets/Images/schoolLogos/LHA.png",
                IconWidth = 120
            };
            var jpiLogo = new School
            {
                Name = "John Paul I Junior High School",
                RouteName = "johnpauli",
                IconUrl = "/Assets/Images/schoolLogos/JP.png",
                IconWidth = 120
            };
            var lmacLogo = new School
            {
                Name = "Laurier MacDonald High School",
                RouteName = "lauriermacdonald",
                IconUrl = "/Assets/Images/schoolLogos/LMac.png",
                IconWidth = 120
            };
            var mmaLogo = new School
            {
                Name = "Marymount Academy",
                RouteName = "marymount",
                IconUrl = "/Assets/Images/schoolLogos/MM.png",
                IconWidth = 120
            };
            var rshLogo = new School
            {
                Name = "Rosemount High School",
                RouteName = "rousemount",
                IconUrl = "/Assets/Images/schoolLogos/RM.png",
                IconWidth = 120
            };
            var rvLogo = new School
            {
                Name = "Royal Vale School",
                RouteName = "royalvale",
                IconUrl = "/Assets/Images/schoolLogos/RV.png",
                IconWidth = 120
            };
            var vmcLogo = new School
            {
                Name = "Vincent Massey Collegiate",
                RouteName = "vincentmassey",
                IconUrl = "/Assets/Images/schoolLogos/VMC.png",
                IconWidth = 120
            };
            var wmhLogo = new School
            {
                Name = "Westmount High School",
                RouteName = "westmount",
                IconUrl = "/Assets/Images/schoolLogos/WM.png",
                IconWidth = 120
            };
            var rwaLogo = new School
            {
                Name = "Royal West Academy",
                RouteName = "royalwest",
                IconUrl = "/Assets/Images/schoolLogos/RWA.png",
                IconWidth = 240
            };

            return View();
            //接下来就该在 AllSchool 页面 render 上面 Model 生成的数据内容了
        }

        


        //var movie = new Movie() {Name = "Shrek!"};
    }
}