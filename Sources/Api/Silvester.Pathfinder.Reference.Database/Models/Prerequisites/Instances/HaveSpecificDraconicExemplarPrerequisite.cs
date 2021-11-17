using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificDraconicExemplarPrerequisite : BasePrerequisite
    {
        public Guid RequiredDraconicExemplarId { get; set; }
        public DraconicExemplar RequiredDraconicExemplar { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificDraconicExemplar(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredDraconicExemplarId)
        {
            return builder.Add(new HaveSpecificDraconicExemplarPrerequisite { Id = id, RequiredDraconicExemplarId = requiredDraconicExemplarId });
        }
    }
}
