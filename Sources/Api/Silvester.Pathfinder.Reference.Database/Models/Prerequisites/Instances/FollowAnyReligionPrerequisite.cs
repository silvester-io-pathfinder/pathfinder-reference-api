using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class FollowAnyReligionPrerequisite : BasePrerequisite
    {

    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder FollowAnyReligion (this BooleanPrerequisiteBuilder builder, Guid id)
        {
            return builder.Add(new FollowAnyReligionPrerequisite { Id = id });
        }
    }
}
