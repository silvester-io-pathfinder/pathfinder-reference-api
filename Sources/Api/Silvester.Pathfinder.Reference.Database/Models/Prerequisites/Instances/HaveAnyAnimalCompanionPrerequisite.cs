using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveAnyAnimalCompanionPrerequisite : BasePrerequisite
    {

    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveAnyAnimalCompanion(this BooleanPrerequisiteBuilder builder, Guid id)
        {
            return builder.Add(new HaveAnyAnimalCompanionPrerequisite { Id = id });
        }
    }
}
