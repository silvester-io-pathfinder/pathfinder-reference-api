using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class Legends : Template
    {
        public static readonly Guid ID = Guid.Parse("49679f90-24ee-40a1-9410-071dfd49e29a");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Legends"
            };
        }
    }
}
