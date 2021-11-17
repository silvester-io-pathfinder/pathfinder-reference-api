using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder163 : Template
    {
        public static readonly Guid ID = Guid.Parse("07a996f6-78aa-466d-ac91-5ca9ea94b07e");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #163: Ruins of the Radiant Siege"
            };
        }
    }
}
