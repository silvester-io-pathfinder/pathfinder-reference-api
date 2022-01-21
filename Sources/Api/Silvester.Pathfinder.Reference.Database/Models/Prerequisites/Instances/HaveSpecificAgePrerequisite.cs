using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificAgePrerequisite : BasePrerequisite
    {
        public int Years { get; set; }
        public Comparator Comparator { get; set; }
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificAge(this BooleanPrerequisiteBuilder builder, Guid id, Comparator comparator, int years)
        {
            return builder.Add(new HaveSpecificAgePrerequisite { Id = id, Comparator = comparator, Years = years });
        }
    }
}
