using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveAnyDevotionSpellPrerequisite : Prerequisite
    {

    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveAnyDevotionSpell(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId)
        {
            return builder.Add(bindingId, new HaveAnyDevotionSpellPrerequisite { Id = id});
        }
    }
}
