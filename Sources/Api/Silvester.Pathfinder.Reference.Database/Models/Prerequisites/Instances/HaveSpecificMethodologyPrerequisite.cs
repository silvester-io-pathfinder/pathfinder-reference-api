using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificMethodologyPrerequisite : BasePrerequisite
    {
        public Guid RequiredMethodologyId { get; set; }
        public Methodology RequiredMethodology { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificMethodology(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredMethodologyId)
        {
            return builder.Add(new HaveSpecificMethodologyPrerequisite { Id = id, RequiredMethodologyId = requiredMethodologyId });
        }
    }
}
