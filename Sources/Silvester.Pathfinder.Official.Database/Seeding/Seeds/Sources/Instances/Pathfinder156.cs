using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder156 : AbstractSourceTemplate
    {
        public static readonly Guid ID = Guid.Parse("cd192d17-e2a2-4182-b6a7-0b05979376e8");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #156: The Apocalypse Prophet"
            };
        }
    }
}
