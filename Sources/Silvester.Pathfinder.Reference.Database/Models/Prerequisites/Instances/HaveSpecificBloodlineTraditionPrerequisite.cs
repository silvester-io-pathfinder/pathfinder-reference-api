using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificBloodlineTraditionPrerequisite : Prerequisite
    {
        public Guid RequiredBloodlineMagicTraditionId { get; set; }
        public MagicTradition RequiredBloodlineMagicTradition { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveSpecificBloodlineTradition(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Guid requiredBloodlineMagicTraditionId)
        {
            return builder.Add(bindingId, new HaveSpecificBloodlineTraditionPrerequisite { Id = id, RequiredBloodlineMagicTraditionId = requiredBloodlineMagicTraditionId });
        }
    }
}
