using System;
using DAL.Entities;

namespace BL.Entities.Dto
{
    public class JobOfferSkillDto
    {
        public int JobOfferId { get; set; }

        public JobOfferDto JobOffer { get; set; }

        public int SkillId { get; set; }

        public SkillDto Skill { get; set; }
    }
}
