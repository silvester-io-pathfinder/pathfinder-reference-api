using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificHeritagePrerequisite : BasePrerequisite
    {
        public Guid RequiredHeritageId { get; set; }
        public Heritage RequiredHeritage { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificHeritage(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredHeritageId)
        {
            return builder.Add(new HaveSpecificHeritagePrerequisite { Id = id, RequiredHeritageId = requiredHeritageId });
        }
    }
}
