using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificAncestryAmountPreqrequisite : BasePrerequisite
    {
        public int Amount { get; set; }
        public Comparator Comparator { get; set; }
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificAncestryAmount(this BooleanPrerequisiteBuilder builder, Guid id, Comparator comparator, int amount)
        {
            return builder.Add(new HaveSpecificAncestryAmountPreqrequisite { Id = id, Comparator = comparator, Amount = amount });
        }
    }
}
