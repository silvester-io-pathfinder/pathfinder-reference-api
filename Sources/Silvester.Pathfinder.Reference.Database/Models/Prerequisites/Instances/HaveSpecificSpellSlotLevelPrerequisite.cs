using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

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
