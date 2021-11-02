using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificSpellDcProficiencyPrerequisite : BasePrerequisite
    {
        public Guid RequiredProfiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificSpellDcProficiency(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredProfiencyId)
        {
            return builder.Add(new HaveSpecificSpellDcProficiencyPrerequisite { Id = id, RequiredProfiencyId = requiredProfiencyId });
        }
    }
}
