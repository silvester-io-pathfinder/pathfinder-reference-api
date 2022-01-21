using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificSpellSlotLevelPrerequisite : BasePrerequisite
    {
        public int SpellSlotLevel { get; set; }
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificSpellSlotLevel(this BooleanPrerequisiteBuilder builder, Guid id, int spellSlotLevel)
        {
            return builder.Add(new HaveSpecificSpellSlotLevelPrerequisite { Id = id, SpellSlotLevel = spellSlotLevel });
        }
    }
}
