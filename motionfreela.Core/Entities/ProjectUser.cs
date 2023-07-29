using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motionfreela.Core.Entities
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
