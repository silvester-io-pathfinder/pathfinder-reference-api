using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveFocusPoolPrerequisite : BasePrerequisite
    {

    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveFocusPool(this BooleanPrerequisiteBuilder builder, Guid id)
        {
            return builder.Add(new HaveFocusPoolPrerequisite { Id = id });
        }
    }
}
