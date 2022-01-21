using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder156 : Template
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
