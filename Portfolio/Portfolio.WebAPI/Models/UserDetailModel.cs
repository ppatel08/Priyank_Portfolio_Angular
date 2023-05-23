using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.WebAPI.Models
{
    public class UserDetailModel
    {
        public string FullName { get; set; }

        public string[] TagLines { get; set; }

        public List<SocialMediaLink> SocialMediaLinks { get; set; }

        public string Email { get; set; }

        public string MobileNumber { get; set; }

        public string  AltMobileNumber { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Zipcode { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string ProfileImgUrl { get; set; }
    }
}