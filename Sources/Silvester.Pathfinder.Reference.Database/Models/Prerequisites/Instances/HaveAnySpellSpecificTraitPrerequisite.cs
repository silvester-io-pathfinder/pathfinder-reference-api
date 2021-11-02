using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveAnySpellSpecificTraitPrerequisite : BasePrerequisite
    {
        public Guid RequiredTraitId { get; set; }
        public Trait RequiredTrait { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveAnySpellSpecificTrait(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredTraitId)
        {
            return builder.Add(new HaveAnySpellSpecificTraitPrerequisite { Id = id, RequiredTraitId = requiredTraitId });
        }
    }
}
