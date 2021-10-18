using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificFeatPrerequisite : Prerequisite
    {
        public Guid RequiredFeatId { get; set; }
        public Feat RequiredFeat { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveSpecificFeat(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Guid requiredFeatId)
        {
            return builder.Add(bindingId, new HaveSpecificFeatPrerequisite { Id = id, RequiredFeatId = requiredFeatId });
        }
    }
}
