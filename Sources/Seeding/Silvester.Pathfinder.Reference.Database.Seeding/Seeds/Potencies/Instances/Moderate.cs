using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Potencies.Instances
{
    public class Moderate : Template
    {
        public static readonly Guid ID = Guid.Parse("de779bc7-3125-409a-82bb-49e68820101a");

        protected override Potency GetPotency()
        {
            return new Potency
            {
                Id = ID,
                Name = "Moderate",
                Order = 3
            };
        }
    }
}
