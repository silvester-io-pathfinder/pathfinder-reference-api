using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveNoMagicSchoolPrerequisite : BasePrerequisite
    {

    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveNoMagicSchool(this BooleanPrerequisiteBuilder builder, Guid id)
        {
            return builder.Add(new HaveNoMagicSchoolPrerequisite { Id = id });
        }
    }
}
