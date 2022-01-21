using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificSpellPrerequisite : BasePrerequisite
    {
        public Guid RequiredSpellId { get; set; } 
        public Spell RequiredSpell { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificSpell(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredSpellId)
        {
            return builder.Add(new HaveSpecificSpellPrerequisite { Id = id, RequiredSpellId = requiredSpellId });
        }
    }
}
