using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EMSB_Intl_Cs_MCV
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                "Admission",                                           // 任意命名
                "Admission",                                           // 要 route 的目的地 URL 要是带{}则是“不论”的意思
                new { Controller = "Admission", Action = "Step1" }
            );

            routes.MapRoute(
                "Schools",
                "Schools",
                new { Controller = "Schools", Action = "AllSchools", schoolName = UrlParameter.Optional }
            );

            //routes.MapRoute(
            //    "Students",
            //    "Students",
            //    new { Controller = "Students", Action = "FieldTrips", studentEvent = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );




        }

    }
}
