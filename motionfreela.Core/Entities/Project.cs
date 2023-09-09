using motionfreela.Core.Enums;

namespace motionfreela.Core.Entities
{
    public class Project : BaseEntity
    {
        public Project(int ownerId, string title, string description)
        {
            OwnerId = ownerId;
            Title = title;
            Description = description;
            CreatedAt = DateTime.Now;
            Status = ProjectStatusEnum.Created;
        }

        public int OwnerId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DeadlineDate { get; set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinisehdAt { get; private set; }
        public ProjectStatusEnum Status { get; set; }

        public void Cancel()
        {
            if (Status == ProjectStatusEnum.Created || Status == ProjectStatusEnum.InProgress || Status == ProjectStatusEnum.Suspended)
            {
                Status = ProjectStatusEnum.Canceled;
                UpdatedAt = DateTime.Now;
            }
        }
        public void Start()
        {
            if(Status == ProjectStatusEnum.Created || Status == ProjectStatusEnum.Suspended)
            {
                Status = ProjectStatusEnum.InProgress;
                StartedAt = DateTime.Now;
                UpdatedAt = DateTime.Now;
            }
        }
        public void Finish()
        {
            if (Status == ProjectStatusEnum.InProgress)
            {
                Status = ProjectStatusEnum.Canceled;
                FinisehdAt = DateTime.Now;
            }
        }
        public void Update(string title, string description, DateTime startDate, DateTime deadlineDate)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            DeadlineDate = deadlineDate;
        }
    }
}
