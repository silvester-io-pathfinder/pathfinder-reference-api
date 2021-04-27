using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Potencies;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Potencies.Instances
{
    public class Moderate : AbstractPotencyTemplate
    {
        public static readonly Guid ID = Guid.Parse("de779bc7-3125-409a-82bb-49e68820101a");

        protected override Potency GetPotency()
        {
            return new Potency
            {
                Id = ID,
                Name = "Moderate"
            };
        }
    }
}
