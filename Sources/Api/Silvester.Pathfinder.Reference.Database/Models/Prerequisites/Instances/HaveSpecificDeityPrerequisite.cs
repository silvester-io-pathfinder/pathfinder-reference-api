using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;


namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificDeityPrerequisite : BasePrerequisite
    {
        public Guid RequiredDeityId { get; set; }
        public Deity RequiredDeity { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificDeity(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredDeityId)
        {
            return builder.Add(new HaveSpecificDeityPrerequisite { Id = id, RequiredDeityId = requiredDeityId });
        }
    }
}
