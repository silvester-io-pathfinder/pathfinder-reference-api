using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;


namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificDruidicOrderPrerequisite : BasePrerequisite
    {
        public Guid RequiredDruidicOrderId { get; set; }
        public DruidicOrder RequiredDruidicOrder { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificDruidicOrder(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredDruidicOrderId)
        {
            return builder.Add(new HaveSpecificDruidicOrderPrerequisite { Id = id, RequiredDruidicOrderId = requiredDruidicOrderId});
        }
    }
}
