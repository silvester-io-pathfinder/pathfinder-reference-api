using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder161 : Template
    {
        public static readonly Guid ID = Guid.Parse("Pathfinder161");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #161: Belly of the Black Whale"
            };
        }
    }
}
