using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    /// <summary>Adds a Skill to a SkillAction with it can be used.</summary>
    public class EnableSkillActionEffect : BaseEffect
    {
        public Guid SkillId { get; set; }
        public Skill Skill { get; set; } = default!;

        public Guid SkillActionId { get; set; }
        public SkillAction SkillAction { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder EnableSkillAction(this BooleanEffectBuilder builder, Guid id, Guid skillId, Guid skillActionId)
        {
            return builder.Add(new EnableSkillActionEffect { Id = id, SkillId = skillId, SkillActionId = skillActionId });
        }
    }
}
