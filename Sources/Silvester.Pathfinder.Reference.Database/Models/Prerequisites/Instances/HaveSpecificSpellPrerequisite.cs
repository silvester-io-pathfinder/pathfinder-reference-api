using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificSpellPrerequisite : Prerequisite
    {
        public Guid RequiredSpellId { get; set; } 
        public Spell RequiredSpell { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveSpecificSpell(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Guid requiredSpellId)
        {
            return builder.Add(bindingId, new HaveSpecificSpellPrerequisite { Id = id, RequiredSpellId = requiredSpellId });
        }
    }
}
