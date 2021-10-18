using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificSkillProficiencyPrerequisite : Prerequisite
    {
        public Guid RequiredSkillId { get; set; } 
        public Skill RequiredSkill { get; set; } = default!;

        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveSpecificSkillProficiency(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Guid requiredProficiencyId, Guid requiredSkillId)
        {
            return builder.Add(bindingId, new HaveSpecificSkillProficiencyPrerequisite { Id = id, RequiredProficiencyId = requiredProficiencyId, RequiredSkillId = requiredSkillId });
        }
    }
}
