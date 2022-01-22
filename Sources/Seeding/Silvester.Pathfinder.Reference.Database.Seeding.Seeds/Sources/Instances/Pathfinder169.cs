using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder169 : Template
    {
        public static readonly Guid ID = Guid.Parse("1025e2b4-c02c-44b3-93c5-6a2d0ec5e318");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #169: Kindled Magic"
            };
        }
    }
}
