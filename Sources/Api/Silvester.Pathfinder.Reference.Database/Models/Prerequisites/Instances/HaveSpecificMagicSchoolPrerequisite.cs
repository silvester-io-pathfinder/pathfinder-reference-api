using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificMagicSchoolPrerequisite : BasePrerequisite
    {
        public Guid RequiredMagicSchoolId { get; set; }
        public MagicSchool RequiredMagicSchool { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificMagicSchool(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredMagicSchoolId, bool isNegated = false)
        {
            return builder.Add(new HaveSpecificMagicSchoolPrerequisite { Id = id, RequiredMagicSchoolId = requiredMagicSchoolId, IsNegated = isNegated });
        }
    }
}
