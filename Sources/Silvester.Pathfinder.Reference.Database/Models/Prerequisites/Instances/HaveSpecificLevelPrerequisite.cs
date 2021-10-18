using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificLevelPrerequisite : Prerequisite
    {
        public int RequiredLevel { get; set; }
        public Comparator Comparator { get; set; }
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveSpecificLevel(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Comparator comparator, int requiredLevel)
        {
            return builder.Add(bindingId, new HaveSpecificLevelPrerequisite { Id = id, Comparator = comparator, RequiredLevel = requiredLevel });
        }
    }
}
