using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificTraitPrerequisite : BasePrerequisite
    {
        public Guid RequiredTraitId { get; set; }
        public Trait RequiredTrait { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificTrait(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredTraitId)
        {
            return builder.Add(new HaveSpecificTraitPrerequisite { Id = id, RequiredTraitId = requiredTraitId});
        }
    }
}
