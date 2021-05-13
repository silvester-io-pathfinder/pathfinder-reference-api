using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder160 : Template
    {
        public static readonly Guid ID = Guid.Parse("39b6a1dc-2aaa-4446-9988-b1834700598a");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #160: Assault on Hunting Lodge Seven"
            };
        }
    }
}
