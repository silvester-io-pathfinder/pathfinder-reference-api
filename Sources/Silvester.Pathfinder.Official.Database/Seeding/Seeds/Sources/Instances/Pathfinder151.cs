using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder151 : AbstractSourceTemplate
    {
        public static readonly Guid ID = Guid.Parse("e2bce868-644b-4602-815e-e0fce4807063");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #151: The Show Must Go On"
            };
        }
    }
}
