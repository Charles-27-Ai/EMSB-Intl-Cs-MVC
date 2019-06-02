using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMSB_Intl_Cs_MCV.Models
{
    public class StudentTitle
    {
        public string Name { get; set; }
        public string Route { get; set; }
        public string Url { get; set; }
        public string Class { get; set; }
    }

    public class StudentCard
    {
        public string RouteName { get; set; }
        public string ImgUrl { get; set; }
        public string IconUrl { get; set; }
        public string AltText { get; set; }
        public string Heading { get; set; }
        public string HeadingFont { get; set; }
        public string SubTitle { get; set; }
    }

    public class StudentList
    {
        public string LinkUrl { get; set; }
        public string LinkIcon { get; set; }
        public string LinkText { get; set; }
        public string LinkHeading { get; set; }
    }

    public class FieldTripDetail
    {
        public string TripName { get; set; }
        public string[] ImgUrl { get; set; }
        public string TripIntro { get; set; }
        public string IntroIcon { get; set; }
        public string Location { get; set; }
        public string DateTime { get; set; }
        public string MeetingPoint { get; set; }
        public string Transport { get; set; }
        public string Back { get; set; }
        public string ToBring { get; set; }
        public string ToWear { get; set; }
        public string[] Schedule { get; set; }
    }
}