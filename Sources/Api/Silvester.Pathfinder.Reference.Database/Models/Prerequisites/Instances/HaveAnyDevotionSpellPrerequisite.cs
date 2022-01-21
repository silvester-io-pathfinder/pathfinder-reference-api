using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveAnyDevotionSpellPrerequisite : BasePrerequisite
    {

    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveAnyDevotionSpell(this BooleanPrerequisiteBuilder builder, Guid id)
        {
            return builder.Add(new HaveAnyDevotionSpellPrerequisite { Id = id});
        }
    }
}
