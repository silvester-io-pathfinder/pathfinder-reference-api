using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificAnimalCompanionAmountPrerequisite : BasePrerequisite
    {
        public int Amount { get; set; }
        public Comparator Comparator { get; set; }
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificAnimalCompanionAmount(this BooleanPrerequisiteBuilder builder, Guid id, Comparator comparator, int amount)
        {
            return builder.Add(new HaveSpecificAnimalCompanionAmountPrerequisite { Id = id, Comparator = comparator, Amount = amount });
        }
    }
}
