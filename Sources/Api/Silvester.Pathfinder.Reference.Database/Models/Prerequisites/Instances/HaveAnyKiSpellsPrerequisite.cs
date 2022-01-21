using System;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveAnyKiSpellsPrerequisite : BasePrerequisite
    {

    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveAnyKiSpells(this BooleanPrerequisiteBuilder builder, Guid id)
        {
            return builder.Add(new HaveAnyKiSpellsPrerequisite { Id = id});
        }
    }
}
