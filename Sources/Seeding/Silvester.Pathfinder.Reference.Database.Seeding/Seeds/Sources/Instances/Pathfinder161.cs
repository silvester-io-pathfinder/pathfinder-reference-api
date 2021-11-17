using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder161 : Template
    {
        public static readonly Guid ID = Guid.Parse("d7c6d7c1-46bf-4316-aab6-65a26cdf74d5");

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
