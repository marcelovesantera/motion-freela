using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motionfreela.Application.ViewModels
{
    public  class ProjectViewModel
    {
        public ProjectViewModel(int ownerId, string title, string description)
        {
            OwnerId = ownerId;
            Title = title;
            Description = description;
        }

        public int OwnerId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; set; }
    }
}
