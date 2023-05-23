using Portfolio.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace Portfolio.WebAPI.Repository
{
    public class HomeRepository
    {

        public async Task<bool> SendMessage(sendMessageModel payload)
        {

            try
            {
                var message = new MailMessage();
                message.To.Add(new MailAddress("priyank.patel118@gmail.com"));
                message.From = new MailAddress(payload.Email);
                message.Subject = "Email from Portfolio";
                message.Body = ($"<html><body></body><h1>Email from Portfolio</h1><br/><p>Below is detail of user</p><br/><p>Name: {payload.Name}</p><p>Email: {payload.Email}</p><p>Message: {payload.Message}</p></html>");
                message.IsBodyHtml = true;
                using (var smtp = new SmtpClient())
                {
                    smtp.EnableSsl = true;

                   // await smtp.SendMailAsync(message);
                }
            }
            catch(Exception ex)
            {
              
            }
          
            return true;
        }

        public GetPortfolioModel GetPortfolioDetail(string userName)
        {
            GetPortfolioModel obj = new GetPortfolioModel()
            {
                UserDetail = new UserDetailModel
                {
                    FullName = "Priyank Patel",
                    MobileNumber = "(586) 533 - 8795",
                    Address = "",
                    City = "Detroit",
                    Country = "USA",
                    State = "Michigan",
                    Zipcode = "48317",
                    Email = "priyank.patel118@gmail.com",
                    ProfileImgUrl = "/images/profile/PriyankPatel.jpg",
                    SocialMediaLinks = new List<SocialMediaLink>()
                    {
                        new SocialMediaLink()
                        {
                            Name = "Linked In",
                            Link = "https://linkedin.com/in/priyank-patel-56b724187",
                             ClassName = "bi-linkedin"
                        },
                        new SocialMediaLink()
                        {
                            Name = "GitHub",
                            Link = "https://github.com/ppatel08",
                             ClassName =  "bi-github"
                        },
                    },
                    TagLines = new string[] { "I'm Priyank Patel", "I'm a FullStack Developer", "I'm a Angular Developer", "I'm a .Net Developer" }
                },
                AboutMe = new AboutMeModel()
                {
                    Title = "I'm Priyank Patel, A Full Stack Developer",
                    Summary = "Software developer with strong technical skills in complex website development including web-based application. Experience in system analysis, design, workflow architecture, development, testing and maintenance of web-based application and single page applications. Well versed in .NET, C#, HTML,CSS and JavaScript."
                },
                WhatIDo = new List<WhatIDoModel>()
                {
                    new WhatIDoModel()
                    {
                        IconName="fas fa-palette",
                        Title="Graphic Design",
                        Description="I love creating logo in Adobe Illustrator, Photoshop "
                    },
                     new WhatIDoModel()
                    {
                        IconName="fas fa-desktop",
                        Title="Web Design",
                        Description="Self motiviated web designer who love to create a beautifull project"
                    },
                      new WhatIDoModel()
                    {
                        IconName="fas fa-pencil-ruler",
                        Title="App Design & Develop",
                        Description="Creating App Design, prototyping the app in Figma, Adobe Photoshop to show the mock up of the Page"
                    },
                       new WhatIDoModel()
                    {
                        IconName="fas fa-bullhorn",
                        Title="SEO Marketing",
                        Description="Full Self aware of how the SEO work and how the SEO work to advertise your website better"
                    }
                },

                MyWorks = new List<MyWorkModel>()
                {
                    new MyWorkModel()
                    {
                        Title="GPWO",
                        Category="Freelancer",
                        ImageURL ="/images/portfolio/GPWO.png"
                    },
                     new MyWorkModel()
                    {
                        Title="PTHub",
                        Category="Freelancer",
                        ImageURL ="/images/portfolio/PTHub.png"
                    },
                      new MyWorkModel()
                    {
                        Title="TPAReporting",
                        Category="Professional",
                        ImageURL ="/images/portfolio/TPAReporting.png"
                    },
                       new MyWorkModel()
                    {
                        Title="GoogleBookAPI",
                        Category="Interview",
                        ImageURL ="/images/portfolio/GoogleBookAPI.png"
                    },
                        new MyWorkModel()
                    {
                        Title="YoutubeAPI",
                        Category="Interview",
                        ImageURL ="/images/portfolio/YoutubeAPI.png"
                    }
                },
                Resume = new ResumeModel()
                {
                    Skills = new List<SkillsModel>()
                {
                    new SkillsModel()
                    {
                        Name="Angular",
                    },
                     new SkillsModel()
                    {
                        Name="React JS",
                    },
                      new SkillsModel()
                    {
                        Name=".Net ",
                    },
                       new SkillsModel()
                    {
                        Name=".Net Core",
                    },
                        new SkillsModel()
                    {
                        Name="Web Design",
                    },
                         new SkillsModel()
                    {
                        Name="Cypress",
                    },
                          new SkillsModel()
                    {
                        Name="HTML5/Css3",
                    },
                           new SkillsModel()
                    {
                        Name="Bootstrap",
                    },
                            new SkillsModel()
                    {
                        Name="SQL",
                    },
                             new SkillsModel()
                    {
                        Name="Mongo DB",
                    },
                               new SkillsModel()
                    {
                        Name="Cosmos DB",
                    },
                },
                    Experiences = new List<ExperienceModel>()
                    {
                        new ExperienceModel()
                        {
                            StartYear ="Dec 2019",
                            EndYear ="Present",
                            JobTitle ="Full Stack Developer",
                            CompanyName = "The Physician Alliance",
                            Description="TPA represents 2,200+ physicians in southeast Michigan dedicated to improving patient quality of care."
                        },
                         new ExperienceModel()
                        {
                            StartYear ="June 2019",
                            EndYear ="December 2019",
                            JobTitle ="Front End Web Developer ",
                            CompanyName = "Little Caesars Pizza",
                            Description="Little Caesar Enterprises Inc is an American multinational pizza chain company."
                        },
                          new ExperienceModel()
                        {
                            StartYear ="Jan 2017",
                            EndYear ="June 2019",
                            JobTitle ="Together Health Network ",
                            CompanyName = "SouthField-MI",
                            Description="Together Health Network connects physicians and providers across the state, positioning them to move into new value-based contracts."
                        }
                    }
                }
            };




            return obj;

        }
    }

}
