using System;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveAnyFamiliarPrerequisite : BasePrerequisite
    {

    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveAnyFamiliar(this BooleanPrerequisiteBuilder builder, Guid id)
        {
            return builder.Add(new HaveAnyFamiliarPrerequisite { Id = id });
        }
    }
}
