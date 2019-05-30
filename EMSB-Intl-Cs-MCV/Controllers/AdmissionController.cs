using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMSB_Intl_Cs_MCV.Controllers
{
    public class AdmissionController : Controller
    {
        // GET: Admission
        public ActionResult Step1()
        {
            ViewBag.Message = "把从 Model 传来的信息通过算法分发到 View";
            return View();
        }

        public ActionResult Step2()
        {
            return View();
        }

        public ActionResult Step3()
        {
            return View();
        }
    }
}