using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;


namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificSensePrerequisite : BasePrerequisite
    {
        public Guid RequiredSenseId { get; set; } 
        public Sense RequiredSense { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificSense(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredSenseId)
        {
            return builder.Add(new HaveSpecificSensePrerequisite { Id = id, RequiredSenseId = requiredSenseId});
        }
    }
}
