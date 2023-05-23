using System.Collections.Generic;

namespace Portfolio.WebAPI.Models
{
    public class ResumeModel
    {
        public List<EductionModel> Eductions { get; set; }

        public List<ExperienceModel> Experiences { get; set; }

        public List<SkillsModel> Skills { get; set; }
    }
}