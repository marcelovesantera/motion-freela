using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motionfreela.Application.InputModels
{
    public class UpdateProjectInputModel : BaseInputModel
    {
        public string Title { get; private set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DeadlineDate { get; set; }
    }
}
