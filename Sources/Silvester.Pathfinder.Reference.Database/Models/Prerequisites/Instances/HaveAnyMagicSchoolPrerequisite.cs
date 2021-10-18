using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveAnyMagicSchoolPrerequisite : Prerequisite
    {

    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveAnyMagicSchool(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId)
        {
            return builder.Add(bindingId, new HaveAnyMagicSchoolPrerequisite { Id = id});
        }
    }
}
