using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMSB_Intl_Cs_MCV.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Student
        public ActionResult FieldTrips()
        {
            return View();
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