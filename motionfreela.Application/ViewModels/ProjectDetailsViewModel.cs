using motionfreela.Application.InputModels;
using motionfreela.Core.Entities;
using motionfreela.Core.Enums;

namespace motionfreela.Application.ViewModels
{
    public class ProjectDetailsViewModel : BaseInputModel
    {
        public ProjectDetailsViewModel(int ownerId, string title, string description, DateTime createdAt, DateTime? updatedAt, DateTime? startDate, DateTime? deadlineDate, DateTime? startedAt, DateTime? finisehdAt, ProjectStatusEnum status)
        {
            OwnerId = ownerId;
            Title = title;
            Description = description;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            StartDate = startDate;
            DeadlineDate = deadlineDate;
            StartedAt = startedAt;
            FinisehdAt = finisehdAt;
            Status = status;
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
    }
}
