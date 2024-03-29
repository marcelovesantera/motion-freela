﻿namespace motionfreela.Core.Entities
{
    public class ProjectUser : BaseEntity
    {
        public ProjectUser(int projectId, int userId)
        {
            ProjectId = projectId;
            UserId = userId;
        }

        public int ProjectId { get; private set; }
        public int UserId { get; private set; }
    }
}
