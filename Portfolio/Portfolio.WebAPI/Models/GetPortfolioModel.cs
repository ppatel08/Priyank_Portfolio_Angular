using System.Collections.Generic;

namespace Portfolio.WebAPI.Models
{
    public class GetPortfolioModel
    {
        public UserDetailModel UserDetail { get; set; }

        public AboutMeModel AboutMe { get; set; }

        public List<WhatIDoModel> WhatIDo { get; set; }

        public ResumeModel Resume { get; set; }

        public List<MyWorkModel> MyWorks { get; set; }

        public List<TestimonialModel> Testimonials { get; set; }


    }

}