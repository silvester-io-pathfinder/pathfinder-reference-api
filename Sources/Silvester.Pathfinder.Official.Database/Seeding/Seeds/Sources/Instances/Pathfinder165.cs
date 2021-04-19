using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder165 : AbstractSourceTemplate
    {
        public static readonly Guid ID = Guid.Parse("de4c1dea-3ff2-444e-a7d9-7fab0cf297d8");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #165: Eyes of Empty Death"
            };
        }
    }
}
