using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class NightOfTheGrayDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("a587b622-2fab-4aa1-a337-857f100ea5cc");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Night of the Gray Death"
            };
        }
    }
}
