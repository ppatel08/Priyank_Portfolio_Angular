using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.WebAPI.Models
{
    public class EductionModel
    {
        public int StartYear { get; set; }

        public int EndYear { get; set; }

        public string DegreeName { get; set; }

        public string UniversityName { get; set; }

        public string Description { get; set; }

    }
}