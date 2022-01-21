using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificDivineAllyPrerequisite : BasePrerequisite
    {
        public Guid RequiredDivineAllyId { get; set; }
        public DivineAlly RequiredDivineAlly { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificDivineAlly(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredDivineAllyId)
        {
            return builder.Add(new HaveSpecificDivineAllyPrerequisite { Id = id, RequiredDivineAllyId = requiredDivineAllyId });
        }
    }
}
