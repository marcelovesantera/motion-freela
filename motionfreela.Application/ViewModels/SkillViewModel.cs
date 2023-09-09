using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motionfreela.Application.ViewModels
{
    public class SkillViewModel
    {
        public SkillViewModel(string skillName)
        {
            SkillName = skillName;
        }

        public string SkillName { get; private set; }
    }
}
