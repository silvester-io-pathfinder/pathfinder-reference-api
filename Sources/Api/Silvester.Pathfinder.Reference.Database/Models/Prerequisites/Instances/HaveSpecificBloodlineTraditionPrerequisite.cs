using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificBloodlineTraditionPrerequisite : BasePrerequisite
    {
        public Guid RequiredBloodlineMagicTraditionId { get; set; }
        public MagicTradition RequiredBloodlineMagicTradition { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificBloodlineTradition(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredBloodlineMagicTraditionId)
        {
            return builder.Add(new HaveSpecificBloodlineTraditionPrerequisite { Id = id, RequiredBloodlineMagicTraditionId = requiredBloodlineMagicTraditionId });
        }
    }
}
