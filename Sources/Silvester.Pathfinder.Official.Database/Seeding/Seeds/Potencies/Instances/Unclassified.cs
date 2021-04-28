using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Potencies;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Potencies.Instances
{
    public class Unclassified : AbstractPotencyTemplate
    {
        public static readonly Guid ID = Guid.Parse("5e2f27d1-6b8b-41a0-8f58-095a4bb926d3");

        protected override Potency GetPotency()
        {
            return new Potency
            {
                Id = ID,
                Name = "Unclassified",
                Order = 0
            };
        }
    }
}
