using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificMovementMethodPrerequisite : BasePrerequisite
    {
        public MovementMethod RequiredMovementMethod { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificMovementMethod(this BooleanPrerequisiteBuilder builder, Guid id, MovementMethod requiredMovementMethod)
        {
            return builder.Add(new HaveSpecificMovementMethodPrerequisite { Id = id, RequiredMovementMethod = requiredMovementMethod });
        }
    }
}
