namespace motionfreela.Core.Entities
{
    internal class UserSkill : BaseEntity
    {
        public UserSkill(int userId, int skillId)
        {
            UserId = userId;
            SkillId = skillId;
        }

        public int UserId { get; private set; }
        public int SkillId { get; private set; }
    }
}
