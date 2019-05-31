using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMSB_Intl_Cs_MCV.Models
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String RouteName { get; set; }
        public String IconUrl { get; set; }
        public int IconWidth { get; set; }
        public Array ImgUrl { get; set; }
        public String Intro { get; set; }
        public String Address { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public String Website { get; set; }
        public Array Philo { get; set; }
        //快捷键：prop + TAB
    }
}