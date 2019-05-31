using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace EMSB_Intl_Cs_MCV.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)] 
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}