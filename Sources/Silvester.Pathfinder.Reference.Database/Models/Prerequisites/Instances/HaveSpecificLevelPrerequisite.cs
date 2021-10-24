using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificLevelPrerequisite : BasePrerequisite
    {
        public int RequiredLevel { get; set; }
        public Comparator Comparator { get; set; }
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificLevel(this BooleanPrerequisiteBuilder builder, Guid id, Comparator comparator, int requiredLevel)
        {
            return builder.Add(new HaveSpecificLevelPrerequisite { Id = id, Comparator = comparator, RequiredLevel = requiredLevel });
        }
    }
}
