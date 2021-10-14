using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    /// <summary>Adds a Skill to a SkillAction with it can be used.</summary>
    public class SkillActionSkillEffect : Effect
    {
        public Guid SkillId { get; set; }
        public Skill Skill { get; set; } = default!;

        public Guid SkillActionId { get; set; }
        public SkillAction SkillAction { get; set; } = default!;
    }
}
