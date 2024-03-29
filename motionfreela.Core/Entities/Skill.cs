﻿namespace motionfreela.Core.Entities
{
    public class Skill : BaseEntity
    {
        public Skill(string skill)
        {
            SkillName = skill;
            CreatedAt = DateTime.Now;
        }
        public string SkillName { get; private set; }
        public DateTime CreatedAt { get; set; }
    }
}
