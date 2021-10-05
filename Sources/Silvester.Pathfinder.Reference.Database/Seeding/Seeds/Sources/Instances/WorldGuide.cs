using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class WorldGuide : Template
    {
        public static readonly Guid ID = Guid.Parse("fc93169c-2136-4e9c-9868-c5f0bb79b331");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "World Guide"
            };
        }
    }
}
