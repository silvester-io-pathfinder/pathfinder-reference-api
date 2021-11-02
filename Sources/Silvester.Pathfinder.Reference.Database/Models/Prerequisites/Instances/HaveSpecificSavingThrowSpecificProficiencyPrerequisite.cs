using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;


namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificSavingThrowSpecificProficiencyPrerequisite : BasePrerequisite
    {
        public Guid RequiredSavingThrowStatId { get; set; }
        public SaviingThrowStat RequiredSavingThrowStat { get; set; } = default!;

        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificSavingThrowSpecificProficiency(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredProficiencyId, Guid requiredSavingThrowStatId)
        {
            return builder.Add(new HaveSpecificSavingThrowSpecificProficiencyPrerequisite { Id = id, RequiredProficiencyId = requiredProficiencyId, RequiredSavingThrowStatId = requiredSavingThrowStatId});
        }
    }
}
