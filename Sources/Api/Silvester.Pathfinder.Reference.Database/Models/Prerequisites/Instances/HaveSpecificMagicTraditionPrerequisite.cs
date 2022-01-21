using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificMagicTraditionPrerequisite : BasePrerequisite
    {
        public Guid RequiredMagicTraditionId { get; set; }
        public MagicTradition RequiredMagicTradition { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificMagicTradition(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredMagicTraditionId)
        {
            return builder.Add(new HaveSpecificMagicTraditionPrerequisite { Id = id, RequiredMagicTraditionId = requiredMagicTraditionId});
        }
    }
}
