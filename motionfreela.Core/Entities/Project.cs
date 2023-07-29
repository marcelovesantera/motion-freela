using motionfreela.Core.Enums;

namespace motionfreela.Core.Entities
{
    internal class Project : BaseEntity
    {
        public Project(int ownerId, string title, string description)
        {
            OwnerId = ownerId;
            Title = title;
            Description = description;
            Freelancers = new List<User>();
            CreatedAt = DateTime.Now;
            Status = ProjectStatusEnum.Created;
        }

        public int OwnerId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; set; }
        public List<User> Freelancers { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public DateTime StartedAt { get; private set; }
        public DateTime FinisehdAt { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public ProjectStatusEnum Status { get; set; }
    }
}
