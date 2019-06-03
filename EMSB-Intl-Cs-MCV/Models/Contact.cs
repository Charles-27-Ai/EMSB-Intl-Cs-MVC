using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMSB_Intl_Cs_MCV.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string Post { get; set; }
        public string[] Schools { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Icon { get; set; }
    }
}