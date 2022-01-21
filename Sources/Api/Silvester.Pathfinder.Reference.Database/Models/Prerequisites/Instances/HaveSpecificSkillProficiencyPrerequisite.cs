using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificSkillProficiencyPrerequisite : BasePrerequisite
    {
        public Guid RequiredSkillId { get; set; } 
        public Skill RequiredSkill { get; set; } = default!;

        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificSkillProficiency(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredProficiencyId, Guid requiredSkillId)
        {
            return builder.Add(new HaveSpecificSkillProficiencyPrerequisite { Id = id, RequiredProficiencyId = requiredProficiencyId, RequiredSkillId = requiredSkillId });
        }
    }
}
