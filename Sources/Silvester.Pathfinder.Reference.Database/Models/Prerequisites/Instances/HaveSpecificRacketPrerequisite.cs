using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificRacketPrerequisite : BasePrerequisite
    {
        public Guid RequiredRacketId { get; set; }
        public Racket RequiredRacket { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificRacket(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredRacketId)
        {
            return builder.Add(new HaveSpecificRacketPrerequisite { Id = id, RequiredRacketId = requiredRacketId });
        }
    }
}
