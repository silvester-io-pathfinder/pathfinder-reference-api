using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificLanguageAmountPrerequisite : BasePrerequisite
    {
        public Comparator Comparator { get; set; }
        public int Amount { get; set; }
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificLanguageAmount(this BooleanPrerequisiteBuilder builder, Guid id, Comparator comparator, int amount)
        {
            return builder.Add(new HaveSpecificLanguageAmountPrerequisite { Id = id, Comparator = comparator, Amount = amount });
        }
    }
}
