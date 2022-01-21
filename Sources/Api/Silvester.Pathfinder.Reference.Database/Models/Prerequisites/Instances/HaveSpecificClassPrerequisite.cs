using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificClassPrerequisite : BasePrerequisite
    {
        public Guid RequiredClassId { get; set; }
        public Class RequiredClass { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificClass(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredClassId)
        {
            return builder.Add(new HaveSpecificClassPrerequisite { Id = id, RequiredClassId = requiredClassId });
        }
    }
}
