using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Potencies;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Potencies.Instances
{
    public class Lesser : AbstractPotencyTemplate
    {
        public static readonly Guid ID = Guid.Parse("ceca3c25-9aec-4b3e-ba74-2e13dbe60a8c");

        protected override Potency GetPotency()
        {
            return new Potency
            {
                Id = ID,
                Name = "Lesser",
                Order = 2
            };
        }
    }
}
