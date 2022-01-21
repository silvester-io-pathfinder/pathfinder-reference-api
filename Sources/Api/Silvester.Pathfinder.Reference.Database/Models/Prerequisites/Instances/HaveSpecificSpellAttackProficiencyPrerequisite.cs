using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificSpellAttackProficiencyPrerequisite : BasePrerequisite
    {
        public Guid RequiredProfiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificSpellAttackProficiency(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredProfiencyId)
        {
            return builder.Add(new HaveSpecificSpellAttackProficiencyPrerequisite { Id = id, RequiredProfiencyId = requiredProfiencyId });
        }
    }
}
