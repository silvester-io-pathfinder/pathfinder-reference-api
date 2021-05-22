using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class GamemasteryGuide : Template
    {
        public static readonly Guid ID = Guid.Parse("643d5da8-e766-44c9-9748-7ad1ac97dcbf");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Gamemastery Guide"
            };
        }
    }
}
