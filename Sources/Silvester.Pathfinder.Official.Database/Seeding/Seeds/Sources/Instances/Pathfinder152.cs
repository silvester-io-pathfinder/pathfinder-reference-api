using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder152 : Template
    {
        public static readonly Guid ID = Guid.Parse("2489316c-8014-4677-969a-03cd4b2ff0f0");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #152: Legacy of the Lost God"
            };
        }
    }
}
