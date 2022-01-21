using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder149 : Template
    {
        public static readonly Guid ID = Guid.Parse("ae4bb197-226e-4697-9246-9a4427428843");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #149: Against the Scarlet Triad"
            };
        }
    }
}
