using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder147 : Template
    {
        public static readonly Guid ID = Guid.Parse("19890c1e-264d-4410-a16d-84cc50578253");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #1147: Tomorrow Must Burn"
            };
        }
    }
}
